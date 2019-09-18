from flask import Flask, jsonify, request
from flask_sqlalchemy_session import flask_scoped_session
from sqlalchemy import MetaData, create_engine,and_,or_,not_
from sqlalchemy.orm import sessionmaker
from flask_sqlalchemy import SQLAlchemy, inspect
import psycopg2
from datetime import  datetime

app = Flask(__name__)
con = psycopg2.connect(database='API', user='postgres', password='root', host='localhost', port='5432')
cur = con.cursor()
engine = create_engine('postgresql://postgres:root@localhost/API')
app.config['SQLALCHEMY_DATABASE_URI'] = 'postgresql://postgres:root@localhost/API'
app.config['SQLALCHEMY_ECHO'] = True
app.config['SQLALCHEMY_TRACK_MODIFICATIONS'] = True
app.debug = True
session_factory = sessionmaker(bind=engine)
session = flask_scoped_session(session_factory, app)
db = SQLAlchemy(app)


# ----------------Model-----------------------------------------------------------

class Catagory(db.Model):
    catId = db.Column(db.Integer, primary_key=True)
    catName = db.Column(db.String(255))
    book = db.relationship('Book', backref='catagory', lazy='dynamic', )

    def __init__(self, name):
        self.catName = name


class Book(db.Model):
    bookid = db.Column(db.Integer, primary_key=True)
    bookname = db.Column(db.String(255))
    borrowprice = db.Column(db.Float)
    finePerDay = db.Column(db.Float)
    quantity = db.Column(db.Integer)
    Creatby = db.Column(db.Integer, db.ForeignKey('staff.staffid', onupdate='CASCADE', ondelete='CASCADE'),
                        nullable=False)
    CreatDate = db.Column(db.Date)
    Author = db.Column(db.String(255))
    Categoryid = db.Column(db.Integer, db.ForeignKey('catagory.catId', onupdate='CASCADE', ondelete='CASCADE'),
                           nullable=False)
    photo = db.Column(db.String(255))
    borrow = db.relationship('Borrow_details', backref='book', lazy=True)
    Returnbook = db.relationship('Return_details', backref='book', lazy=True)
    iportdetail = db.relationship('Import_details', backref='book', lazy=True)

    def __init__(self, bookname, borrowprice, fineperday, Quantity, Creatby, CreatDate, Author, Catagoryid, photo):
        self.bookname = bookname
        self.borrowprice = borrowprice
        self.finePerDay = fineperday
        self.quantity = Quantity
        self.Creatby = Creatby
        self.CreatDate = CreatDate
        self.Author = Author
        self.Categoryid = Catagoryid
        self.photo = photo


class Borrow_details(db.Model):
    borrowDId = db.Column(db.Integer, primary_key=True)
    borrowid = db.Column(db.Integer, db.ForeignKey('borrow.borrowid', onupdate='CASCADE', ondelete='CASCADE'),
                         nullable=False)
    AutoNum = db.Column(db.Integer)
    Bookid = db.Column(db.Integer, db.ForeignKey('book.bookid', onupdate='CASCADE', ondelete='CASCADE'), nullable=False)
    barcode = db.Column(db.String(255))
    status = db.Column(db.String(255))
    returndetail = db.relationship('Return_details', backref='borrow_details', lazy=True)

    def __init__(self, AutoNum, Bookid, barcode, status):
        self.AutoNum = AutoNum
        self.Bookid = Bookid
        self.barcode = barcode
        self.status = status


class Borrow(db.Model):
    borrowid = db.Column(db.Integer, primary_key=True)
    borrowDate = db.Column(db.Date)
    dateReturn = db.Column(db.Date)
    total = db.Column(db.Float)
    staffid = db.Column(db.Integer, db.ForeignKey('staff.staffid', onupdate='CASCADE', ondelete='CASCADE'),
                        nullable=False)
    studentid = db.Column(db.Integer, db.ForeignKey('student.studentid'), nullable=False)
    cardid = db.Column(db.String(255))

    def __init__(self, borrowDate, dateReturn, total, staffid, studentid, cardid):
        self.borrowDate = borrowDate
        self.dateReturn = dateReturn
        self.total = total
        self.staffid = staffid
        self.studentid = studentid
        self.cardid = cardid


class Return(db.Model):
    returnid = db.Column(db.Integer, primary_key=True)
    returnDate = db.Column(db.Date)
    fee = db.Column(db.Float)
    staffid = db.Column(db.Integer, db.ForeignKey('staff.staffid', onupdate='CASCADE', ondelete='CASCADE'),
                        nullable=False)
    studentid = db.Column(db.Integer, db.ForeignKey('student.studentid', onupdate='CASCADE', ondelete='CASCADE'),
                          nullable=False)
    return_details = db.relationship('Return_details', backref='return', lazy=True)

    def __init__(self, returnDate, fee, staffid, studentid):
        self.returnDate = returnDate
        self.fee = fee
        self.staffid = staffid
        self.studentid = studentid


class Return_details(db.Model):
    returnDid = db.Column(db.Integer, primary_key=True)
    returnid = db.Column(db.Integer, db.ForeignKey('return.returnid', onupdate='CASCADE', ondelete='CASCADE'),
                         nullable=False)
    bookid = db.Column(db.Integer, db.ForeignKey('book.bookid', onupdate='CASCADE', ondelete='CASCADE'), nullable=False)
    barcode = db.Column(db.String(255))
    fine = db.Column(db.Float)
    lateDay = db.Column(db.Integer)
    borrowid = db.Column(db.Integer, db.ForeignKey('borrow_details.borrowDId', onupdate='CASCADE', ondelete='CASCADE'),
                         nullable=False)

    def __init__(self, returnid, bookid, barcode, fine, lateday, borrowid):
        self.returnid = returnid
        self.bookid = bookid
        self.barcode = barcode
        self.fine = fine
        self.lateDay = lateday
        self.borrowid = borrowid


class Student(db.Model):
    studentid = db.Column(db.Integer, primary_key=True)
    name = db.Column(db.String(255))
    sex = db.Column(db.String(10))
    DateOfbirth = db.Column(db.Date)
    phone = db.Column(db.String(255))
    email = db.Column(db.String(255))
    Address = db.Column(db.String(255))
    photo = db.Column(db.String(255))
    CreatDate = db.Column(db.Date)
    Creatby = db.Column(db.Integer, db.ForeignKey('staff.staffid', onupdate='CASCADE', ondelete='CASCADE'),
                        nullable=False)
    printcard = db.relationship('Printcard_details', backref='student', lazy=True)

    def __init__(self, name, sex, dob, phone, email, address, photo, creatDate, CreatBy):
        self.name = name
        self.sex = sex
        self.DateOfbirth = dob
        self.phone = phone
        self.email = email
        self.Address = address
        self.photo = photo
        self.CreatDate = creatDate
        self.Creatby = CreatBy


class Printcard(db.Model):
    printid = db.Column(db.Integer, primary_key=True)
    printDate = db.Column(db.Date)
    total = db.Column(db.Integer)
    Creatby = db.Column(db.Integer, db.ForeignKey('staff.staffid', onupdate='CASCADE', ondelete='CASCADE'),
                        nullable=False)
    printCard_Details = db.relationship('Printcard_details', backref='printcard', lazy=True)

    def __init__(self, printDate, total, Creatby):
        self.printDate = printDate
        self.total = total
        self.Creatby = Creatby


class Printcard_details(db.Model):
    printcardDid = db.Column(db.Integer, primary_key=True)
    printcardid = db.Column(db.Integer, db.ForeignKey('printcard.printid', onupdate='CASCADE', ondelete='CASCADE'),
                            nullable=False)
    cardid = db.Column(db.String(255))
    ExpireDate = db.Column(db.Date)
    AutoNum = db.Column(db.Integer)
    bookQuantity = db.Column(db.Integer)
    price = db.Column(db.Float)
    studentid = db.Column(db.Integer, db.ForeignKey('student.studentid', onupdate='CASCADE', ondelete='CASCADE'),
                          nullable=False)

    def __init__(self, printcardid, cardid, ExpireDate, Autonum, bookQty, price, studentid):
        self.printcardid = printcardid
        self.cardid = cardid
        self.ExpireDate = ExpireDate
        self.AutoNum = Autonum
        self.bookQuantity = bookQty
        self.price = price
        self.studentid = studentid


class Staff(db.Model):
    staffid = db.Column(db.Integer, primary_key=True)
    name = db.Column(db.String(255))
    sex = db.Column(db.String(10))
    DateOfbirth = db.Column(db.Date)
    phone = db.Column(db.String(255))
    email = db.Column(db.String(255))
    Address = db.Column(db.String(255))
    photo = db.Column(db.String(255))
    book = db.relationship('Book', backref='staff', lazy=True)
    printcard = db.relationship('Printcard', backref='staff', lazy=True)
    student = db.relationship('Student', backref='staff', lazy=True)
    expense = db.relationship('Expense', backref='staff', lazy=True)
    collect = db.relationship('Collect', backref='staff', lazy=True)
    borrow = db.relationship('Borrow', backref='staff', lazy=True)
    returnbook = db.relationship('Return', backref='staff', lazy=True)
    Import = db.relationship('Import', backref='staff', lazy=True)
    supplire = db.relationship('Supplier', backref='staff', lazy=True)
    user = db.relationship('User', backref='staff', lazy=True, uselist=False)

    def __init__(self, name, sex, dob, phone, email, address, photo):
        self.name = name
        self.sex = sex
        self.DateOfbirth = dob
        self.phone = phone
        self.email = email
        self.Address = address
        self.photo = photo


class Supplier(db.Model):
    supid = db.Column(db.Integer, primary_key=True)
    supName = db.Column(db.String(255))
    phone = db.Column(db.String(255))
    email = db.Column(db.String(255))
    Address = db.Column(db.String(255))
    CreatDate = db.Column(db.Date)
    Creatby = db.Column(db.Integer, db.ForeignKey('staff.staffid', onupdate='CASCADE', ondelete='CASCADE'),
                        nullable=False)
    importbook = db.relationship('Import', backref='supplier', lazy=True)

    def __init__(self, name, phone, email, address, CreateDate, CreateBy):
        self.supName = name
        self.phone = phone
        self.email = email
        self.Address = address
        self.CreatDate = CreateDate
        self.Creatby = CreateBy


class Import(db.Model):
    importid = db.Column(db.Integer, primary_key=True)
    desciption = db.Column(db.String(255))
    importDate = db.Column(db.Date)
    total = db.Column(db.Float)
    CreatBy = db.Column(db.Integer, db.ForeignKey('staff.staffid', onupdate='CASCADE', ondelete='CASCADE'),
                        nullable=False)
    supid = db.Column(db.Integer, db.ForeignKey('supplier.supid', onupdate='CASCADE', ondelete='CASCADE'),
                      nullable=False)
    importDetail = db.relationship('Import_details', backref='import', lazy=True)
    importbook = db.relationship('Importbook', backref='import', lazy=True)

    def __init__(self, desc, date, total, staff, supplier):
        self.desciption = desc
        self.importDate = date
        self.total = total
        self.CreatBy = staff
        self.supid = supplier


class Import_details(db.Model):
    importDid = db.Column(db.Integer, primary_key=True)
    autonum = db.Column(db.Integer)
    Quantity = db.Column(db.Integer)
    cost = db.Column(db.Float)
    subtotal = db.Column(db.Float)
    bookid = db.Column(db.Integer, db.ForeignKey('book.bookid', onupdate='CASCADE', ondelete='CASCADE'),
                       nullable=False)
    importid = db.Column(db.Integer, db.ForeignKey('import.importid', onupdate='CASCADE', ondelete='CASCADE'),
                         nullable=False)
    importbook = db.relationship('Importbook', backref='import_details', lazy=True)
    stock = db.relationship('Stock', backref='import_details', lazy=True)

    def __init__(self, autonum, qty, cost, subtotal, bookid, importid):
        self.autonum = autonum
        self.Quantity = qty
        self.cost = cost
        self.subtotal = subtotal
        self.bookid = bookid
        self.importid = importid


class Importbook(db.Model):
    importbookid = db.Column(db.Integer, primary_key=True)
    importid = db.Column(db.Integer, db.ForeignKey('import.importid', onupdate='CASCADE', ondelete='CASCADE'),
                         nullable=False)
    bacode = db.Column(db.String(255))
    importdetailid = db.Column(db.Integer,
                               db.ForeignKey('import_details.importDid', onupdate='CASCADE', ondelete='CASCADE'),

                               nullable=False)

    def __init__(self, importid, barcode, importDid):
        self.importid = importid
        self.bacode = barcode
        self.importdetailid = importDid


class Stock(db.Model):
    stockid = db.Column(db.Integer, primary_key=True)
    importdetailid = db.Column(db.Integer,
                               db.ForeignKey('import_details.importDid', onupdate='CASCADE', ondelete='CASCADE'),
                               nullable=False)
    autonum = db.Column(db.Integer)
    Status = db.Column(db.Integer)

    def __init__(self, detailid, autonum, status):
        self.importdetailid = detailid
        self.autonum = autonum
        self.Status = status


class Expense(db.Model):
    expenseid = db.Column(db.Integer, primary_key=True)
    expenseDate = db.Column(db.Date)
    total = db.Column(db.Float)
    CreateBy = db.Column(db.Integer, db.ForeignKey('staff.staffid', onupdate='CASCADE', ondelete='CASCADE'),
                         nullable=False)
    expense_details = db.relationship('Expense_deltails', backref='expense', lazy=True)

    def __init__(self, date, total, createby):
        self.expenseDate = date
        self.total = total
        self.CreateBy = createby


class Expense_deltails(db.Model):
    expenseDid = db.Column(db.Integer, primary_key=True)
    expenseid = db.Column(db.Integer, db.ForeignKey('expense.expenseid', onupdate='CASCADE', ondelete='CASCADE'),
                          nullable=False)
    amount = db.Column(db.Float)
    expenseType = db.Column(db.Integer,
                            db.ForeignKey('expense_type.expenseTid', onupdate='CASCADE', ondelete='CASCADE'),
                            nullable=False)

    def __init__(self, expanseid, amount, expensetype):
        self.expenseid = expanseid
        self.amount = amount
        self.expenseType = expensetype


class Expense_type(db.Model):
    expenseTid = db.Column(db.Integer, primary_key=True)
    expenseType = db.Column(db.String(255))
    expensedetails = db.relationship('Expense_deltails', backref='expense_type', lazy=True)

    def __init__(self, name):
        self.expenseType = name


class Privillage(db.Model):
    privillageid = db.Column(db.Integer, primary_key=True)
    privilagename = db.Column(db.String(255))
    role = db.relationship('Role', backref='privillage', lazy=True)

    def __init__(self, pri):
        self.privilagename = pri


class Role(db.Model):
    roleid = db.Column(db.Integer, primary_key=True)
    rolename = db.Column(db.String(255))
    privillageid = db.Column(db.Integer,
                             db.ForeignKey('privillage.privillageid', onupdate='CASCADE', ondelete='CASCADE'),
                             nullable=False)
    User = db.relationship('User', backref='role', cascade="all, delete-orphan", lazy=True)

    def __init__(self, rolename, privilageid):
        self.rolename = rolename
        self.privillageid = privilageid


class User(db.Model):
    userid = db.Column(db.Integer, primary_key=True)
    username = db.Column(db.String(255))
    password = db.Column(db.String(255))
    is_active = db.Column(db.String(10))
    staffid = db.Column(db.Integer, db.ForeignKey('staff.staffid', onupdate='CASCADE', ondelete='CASCADE'),
                        nullable=False)
    roleid = db.Column(db.Integer, db.ForeignKey('role.roleid', onupdate='CASCADE', ondelete='CASCADE'),
                       nullable=False)

    def __init__(self, name, passwd, is_active, staffid, roleid):
        self.username = name
        self.password = passwd
        self.is_active = is_active
        self.staffid = staffid
        self.roleid = roleid


class Collecttype(db.Model):
    collecttypeid = db.Column(db.Integer, primary_key=True)
    collecttype = db.Column(db.String(255))
    Collect_details = db.relationship('Collect_details', backref='collecttype', lazy=True)

    def __init__(self, collecttype):
        self.collecttype = collecttype


class Collect_details(db.Model):
    collectdid = db.Column(db.Integer, primary_key=True)
    collectid = db.Column(db.Integer, db.ForeignKey('collect.collectid', onupdate='CASCADE', ondelete='CASCADE'),
                          nullable=False)
    subtotal = db.Column(db.Float)
    collecttypeid = db.Column(db.Integer,
                              db.ForeignKey('collecttype.collecttypeid', onupdate='CASCADE', ondelete='CASCADE'),
                              nullable=False)

    def __init__(self, collectid, subtotal, collecttypeid):
        self.collectdid = collectid
        self.subtotal = subtotal
        self.collecttypeid = collecttypeid


class Collect(db.Model):
    collectid = db.Column(db.Integer, primary_key=True)
    collectDate = db.Column(db.Date)
    total = db.Column(db.Float)
    fromDate = db.Column(db.Date)
    todate = db.Column(db.Date)
    Collectby = db.Column(db.Integer, db.ForeignKey('staff.staffid', onupdate='CASCADE', ondelete='CASCADE'),
                          nullable=False)
    collectDetails = db.relationship('Collect_details', backref='collect', lazy=True)

    def __init__(self, date, total, fromdate, todate, collectby):
        self.collectDate = date
        self.total = total
        self.fromDate = fromdate
        self.todate = todate
        self.Collectby = collectby


# ----------------------------------------------------------------------------------------------------------------------------------
# -------------------------------------------------------------Insert---------------------------------------------------------------

def requesJson():
    JSON = request.json
    return JSON


def Add(obj):
    db.session.add(obj)
    db.session.commit()


@app.route('/staff_add', methods=['POST'])
def staff_add():
    # name, sex, dob, phone, email, address, photo
    for itm in requesJson():
        name = itm.get('name')
        sex = itm.get('sex')
        dob = itm.get('dob')
        phone = itm.get('phone')
        email = itm.get('email')
        address = itm.get('address')
        photo = itm.get('photo')
        me = Staff(name, sex, dob, phone, email, address, photo)
        Add(me)
        return staff_all()


@app.route('/user_add', methods=['POST'])
def user_add():
    # name, passwd, is_active, staffid, roleid
    for itm in requesJson():
        name = itm.get('name')
        passwd = itm.get('passwd')
        is_active = itm.get('active')
        staffid = itm.get('staffid')
        roleid = itm.get('roleid')
        me = User(name, passwd, is_active, staffid, roleid)
        Add(me)
        return user_all()


@app.route('/role_add', methods=['POST'])
def role_add():
    for itm in requesJson():
        name = itm.get('name')
        privillageid = itm.get('privillageid')
        me = Role(name, privillageid)
        Add(me)
        return role_all()


@app.route('/privillage_add', methods=['POST'])
def privillage_add():
    for itm in requesJson():
        name =requesJson()['name']
        me = Privillage(name)
        Add(me)
        return privillage_all()


@app.route('/student_add', methods=['POST'])
def student_add():
    #     name, sex, dob, phone, email, address, photo, creatDate, CreatBy
        name = requesJson()['name']
        sex = requesJson()['sex']
        dob = requesJson()['dob']
        phone = requesJson()['phone']
        email = requesJson()['email']
        address = requesJson()['address']
        photo =requesJson()['photo']
        createDate = requesJson()['createDate']
        Createby = requesJson()['createBy']
        me = Student(name, sex, dob, phone, email, address, photo, createDate, Createby)
        Add(me)
        return student_all()


@app.route('/printcrad_add', methods=['POST'])
def printcard_add():
    for itm in requesJson():
        printDate = itm.get('printDate')
        total = itm.get('total')
        Createby = itm.get('Creatby')
        me = Printcard(printDate, total, Createby)
        Add(me)
        return printcard_all()


@app.route('/print_detail_add', methods=['POST'])
def print_detail_add():
    for itm in requesJson():
        printcardid = itm.get('printcardid')
        cardid = itm.get('cardid')
        ExpireDate = itm.get('ExpireDate')
        Autonum = itm.get('Autonum')
        bookQty = itm.get('bookQty')
        price = itm.get('price')
        studenid = itm.get('studenid')
        me = Printcard_details(printcardid, cardid, ExpireDate, Autonum, bookQty, price, studenid)
        Add(me)
        return print_detail_all()


@app.route('/book_add', methods=['POST'])
def book_add():
    # bookname, borrowprice, fineperday, Quantity, Creatby, CreatDate, Author, Catagoryid, photo
    for itm in requesJson():
        bname = itm.get('name')
        borrowprice = itm.get('price')
        finepereday = itm.get('fine')
        Quantity = itm.get('qty')
        Creatby = itm.get('createby')
        CreatDate = itm.get('cratedate')
        Author = itm.get('author')
        Catagoryid = itm.get('catagoryid')
        photo = itm.get('photo')
        me = Book(bname, borrowprice, finepereday, Quantity, Creatby, CreatDate, Author, Catagoryid, photo)
        Add(me)
        return book_all()


@app.route('/catagory_add', methods=['POST'])
def catagory_add():
    for itm in requesJson():
        name = itm.get('name')
        me = Catagory(name)
        Add(me)
        return catagory_all()


@app.route('/collect_add', methods=['POST'])
def collect_add():
    for itm in requesJson():
        date = itm.get('date')
        total = itm.get('total')
        fromdate = itm.get('fromdate')
        todate = itm.get('todate')
        collectby = itm.get('collectby')
        me = Collect(date, total, fromdate, todate, collectby)
        Add(me)
        return collect_all()


@app.route('/collect_detail_add', methods=['POST'])
def collect_detail_add():
    for itm in requesJson():
        id = itm.get('id')
        subtotal = itm.get('subtotal')
        collecttypeid = itm.get('typeid')
        me = Collect_details(id, subtotal, collecttypeid)
        Add(me)
        return collect_detail_all()


@app.route('/collect_type_add', methods=['POST'])
def collect_type_add():
    for itm in requesJson():
        collecttype = itm.get('type')
        me = Collecttype(collecttype)
        Add(me)
        return collect_type_all()


@app.route('/expense_add', methods=['POST'])
def expense_add():
    for itm in requesJson():
        date = itm.get('date')
        total = itm.get('total')
        createby = itm.get('createby')
        me = Expense(date, total, createby)
        Add(me)
        return expense_all()


@app.route('/expense_detail_add', methods=['POST'])
def expense_detail_add():
    for itm in requesJson():
        id = itm.get('id')
        amount = itm.get('amount')
        expensetype = itm.get('type')
        me = Expense_deltails(id, amount, expensetype)
        Add(me)
        return expense_detail_all()


@app.route('/expense_type_add', methods=['POST'])
def expense_type_add():
    for itm in requesJson():
        name = itm.get('name')
        me = Expense_type(name)
        Add(me)
        return expense_type_all()


@app.route('/import_add', methods=['POST'])
def import_add():
    for itm in requesJson():
        desc = itm.get('desc')
        date = itm.get('date')
        total = itm.get('total')
        staff = itm.get('staff')
        supplier = itm.get('supplier')
        me = Import(desc, date, total, staff, supplier)
        Add(me)
        return import_all()


@app.route('/import_detail_add', methods=['POST'])
def import_detail_add():
    for itm in requesJson():
        autonum = itm.get('autonum')
        qty = itm.get('qty')
        cost = itm.get('cost')
        subtotal = itm.get('subtotal')
        bookid = itm.get('bookid')
        importid = itm.get('importid')
        me = Import_details(autonum, qty, cost, subtotal, bookid, importid)
        Add(me)
        return import_detail_all()


@app.route('/importbook_add', methods=['POST'])
def importbook_add():
    for itm in requesJson():
        importid = itm.get('importid')
        barcode = itm.get('barcode')
        importDid = itm.get('importDid')
        me = Importbook(importid, barcode, importDid)
        Add(me)
        return importbook_all()


@app.route('/supplier_add', methods=['POST'])
def supplier_add():
    for itm in requesJson():
        name = itm.get('name')
        phone = itm.get('phone')
        email = itm.get('email')
        address = itm.get('address')
        createdate = itm.get('createdate')
        createby = itm.get('createby')
        me = Supplier(name, phone, email, address, createdate, createby)
        Add(me)
        return supplier_all()


@app.route('/stock_add', methods=['POST'])
def stock_add():
    for itm in requesJson():
        detailid = itm.get('detailid')
        autonum = itm.get('autonum')
        status = itm.get('status')
        me = Stock(detailid, autonum, status)
        Add(me)
        return stock_all()


@app.route('/borrow_add', methods=['POST'])
def borrow_add():
    for itm in requesJson():
        date = itm.get('date')
        datereturn = itm.get('returndate')
        total = itm.get('total')
        staffid = itm.get('staffid')
        studentid = itm.get('studentid')
        cardid = itm.get('cardid')
        me = Borrow(date, datereturn, total, staffid, studentid, cardid)
        Add(me)
        return borrow_all()


@app.route('/borrow_detail_add', methods=['POST'])
def borrow_detail_add():
    for itm in requesJson():
        autonum = itm.get('autonum')
        bookid = itm.get('bookid')
        barcode = itm.get('barcode')
        status = itm.get('status')
        me = Borrow_details(autonum, bookid, barcode, status)
        Add(me)
        return borrow_detail_all();


@app.route('/return_add', methods=['POST'])
def return_add():
    for itm in requesJson():
        returndate = itm.get('returndate')
        fee = itm.get('fee')
        staffid = itm.get('staffid')
        studentid = itm.get('studentid')
        me = Return(returndate, fee, staffid, studentid)
        Add(me)
        return return_add()


@app.route('/return_detail_add', methods=['POST'])
def return_detail_add():
    for itm in requesJson():
        id = itm.get('returnid')
        bookid = itm.get('bookid')
        barcode = itm.get('barcode')
        fine = itm.get('fine')
        lateday = itm.get('lateday')
        borrowid = itm.get('borrowid')
        me = Return_details(id, bookid, barcode, fine, lateday, borrowid)
        Add(me)
        return return_detail_all


# ----------------------------------------------------------------------------------------------------------------------------------
# -------------------------------------------------------------Get All--------------------------------------------------------------
def todict(obj):
    return {c.key: getattr(obj, c.key)
            for c in inspect(obj).mapper.column_attrs}


def addTolist(obj):
    js = []
    for itm in obj:
        data = todict(itm)
        js.append(data)
    return js


@app.route('/staff_all', methods=['POST'])
def staff_all():
    # name, sex, dob, phone, email, address, photo
    find = Staff.query.all()
    return jsonify(addTolist(find))


@app.route('/user_all', methods=['POST'])
def user_all():
    js = []
    cur.execute('SELECT * FROM user_all')
    result = cur.fetchall()
    for itm in result:
        data = {'userid': itm[0], 'username': itm[1], 'password': itm[2], 'is_Active': itm[3], 'staffname': itm[4],
                'rolename': itm[5]}
        js.append(data)
    return jsonify(js)


@app.route('/role_all', methods=['POST'])
def role_all():
    js = []
    cur.execute('SELECT * FROM role_all')
    result = cur.fetchall()
    for itm in result:
        data = {'roleid': itm[0], 'rolename': itm[1], 'privillagename': itm[2]}
        js.append(data)
    return jsonify(js)


@app.route('/privillage_all', methods=['POST'])
def privillage_all():
    find = Privillage.query.all()
    return jsonify(addTolist(find))


@app.route('/student_all', methods=['POST'])
def student_all():
    #     name, sex, dob, phone, email, address, photo, creatDate, CreatBy
    js = []
    cur.execute('SELECT * FROM student_all')
    result = cur.fetchall()
    for itm in result:
        data = {'studentid': itm[0], 'name': itm[1], 'sex': itm[2], 'dateofbirth': itm[3].strftime('%D %d/%B/%Y').split(' ')[1], 'phone': itm[4],
                'email': itm[5], 'Address': itm[6], 'photo': itm[7], 'creatdate': itm[8].strftime('%D %d/%B/%Y').split(' ')[1], 'staffname': itm[9]}
        js.append(data)
    return jsonify(js)


@app.route('/printcrad_all', methods=['POST'])
def printcard_all():
    find = Staff.query.all()
    return jsonify(addTolist(find))


@app.route('/print_detail_all', methods=['POST'])
def print_detail_all():
    js = []
    cur.execute('SELECT * FROM print_details_all')
    result = cur.fetchall()
    for itm in result:
        data = {'printcard_deatailid': itm[0], 'name': itm[1], 'sex': itm[2], 'dateofbirth': itm[3], 'phone': itm[4],
                'email': itm[5], 'Address': itm[6], 'photo': itm[7], 'creatdate': itm[8], 'staffname': itm[9]}
        js.append(data)
    return jsonify(js)


@app.route('/book_all', methods=['POST'])
def book_all():
    js = []
    cur.execute('SELECT * FROM book_all')
    result = cur.fetchall()
    for itm in result:
        data = {'bookid': itm[0], 'bookname': itm[1], 'borrowprice': itm[2], 'fineperday': itm[3], 'quantity': itm[4],
                'createdate': itm[5], 'AuthorName': itm[6], 'Nae': itm[7], 'Catagname': itm[8]}
        js.append(data)
    return jsonify(js)


@app.route('/catagory_all', methods=['POST'])
def catagory_all():
    find = Catagory.query.all()
    return jsonify(addTolist(find))


@app.route('/collect_all', methods=['POST'])
def collect_all():
    js = []
    cur.execute('SELECT * FROM collect_all')
    result = cur.fetchall()
    for itm in result:
        data = {'bookid': itm[0], 'bookname': itm[1], 'borrowprice': itm[2], 'fineperday': itm[3],
                'quantity': itm[4],
                'createdate': itm[5], 'AuthorName': itm[6], 'Nae': itm[7], 'Catagname': itm[8]}
        js.append(data)
    return jsonify(js)


@app.route('/collect_detail_all', methods=['POST'])
def collect_detail_all():
    js = []
    cur.execute('SELECT * FROM collect_details_all')
    result = cur.fetchall()
    for itm in result:
        data = {'Collect_detailid': itm[0], 'collectid': itm[1], 'subtotal': itm[2], 'collecttype': itm[3]}
        js.append(data)
    return jsonify(js)


@app.route('/collect_type_all', methods=['POST'])
def collect_type_all():
    find = Collecttype.query.all();
    return jsonify(addTolist(find))


@app.route('/expense_all', methods=['POST'])
def expense_all():
    js = []
    cur.execute('SELECT * FROM expense_all')
    result = cur.fetchall()
    for itm in result:
        data = {'expenseid': itm[0], 'expesedate': itm[1], 'total': itm[2], 'createby': itm[3]}
        js.append(data)
    return jsonify(js)


@app.route('/expense_detail_all', methods=['POST'])
def expense_detail_all():
    js = []
    cur.execute('SELECT * FROM expense_details_all')
    result = cur.fetchall()
    for itm in result:
        data = {'expense_detailid': itm[0], 'expenseid': itm[1], 'amount': itm[2], 'expensetype': itm[3]}
        js.append(data)
    return jsonify(js)


@app.route('/expense_type_all', methods=['POST'])
def expense_type_all():
    find = Expense_type.query.all()
    return jsonify(addTolist(find))


@app.route('/import_all', methods=['POST'])
def import_all():
    js = []
    cur.execute('SELECT * FROM import_all')
    result = cur.fetchall()
    for itm in result:
        data = {'importid': itm[0], 'desc': itm[1], 'importdate': itm[2], 'total': itm[3], 'Cretbay': itm[4],
                'Suplliername': itm[5]}
        js.append(data)
    return jsonify(js)


@app.route('/import_detail_all', methods=['POST'])
def import_detail_all():
    js = []
    cur.execute('SELECT * FROM import_details_all')
    result = cur.fetchall()
    for itm in result:
        data = {'import_detailid': itm[0], 'Autonum': itm[1], 'quantity': itm[2], 'cost': itm[3], 'subtotal': itm[4],
                'bookname': itm[5], 'importid': itm[6]}
        js.append(data)
    return jsonify(js)


@app.route('/importbook_all', methods=['POST'])
def importbook_all():
    js = []
    cur.execute('SELECT * FROM importbook_all')
    result = cur.fetchall()
    for itm in result:
        data = {'import_bookid': itm[0], 'importid': itm[1], 'barcode': itm[2], 'import_detailid': itm[3],
                'bookname': itm[4]}
        js.append(data)
    return jsonify(js)


@app.route('/supplier_all', methods=['POST'])
def supplier_all():
    js = []
    cur.execute('SELECT * FROM supplier_all')
    result = cur.fetchall()
    for itm in result:
        data = {'supplierid': itm[0], 'SupllierName': itm[1], 'phone': itm[2], 'email': itm[3],
                'Adress': itm[4], 'CreateDate': itm[5], 'Createby': itm[6]}
        js.append(data)
    return jsonify(js)


@app.route('/stock_all', methods=['POST'])
def stock_all():
    js = []
    cur.execute('SELECT * FROM stock_all')
    result = cur.fetchall()
    for itm in result:
        data = {'stockid': itm[0], 'import_detailid': itm[1], 'bookname': itm[2], 'autonum': itm[3],
                'Quantity': itm[4], 'borrowprice': itm[5], 'fineperday': itm[6], 'photo': itm[7], 'status': itm[8]}
        js.append(data)
    return jsonify(js)


@app.route('/borrow_all', methods=['POST'])
def borrow_all():
    js = []
    cur.execute('SELECT * FROM borrow_all')
    result = cur.fetchall()
    for itm in result:
        data = {'borrowid': itm[0], 'borrowdate': itm[1], 'datereturn': itm[2], 'total': itm[3],
                'staffname': itm[4], 'studentname': itm[5], 'cardid': itm[6]}
        js.append(data)
    return jsonify(js)


@app.route('/borrow_detail_all', methods=['POST'])
def borrow_detail_all():
    js = []
    cur.execute('SELECT * FROM borrow_details_all')
    result = cur.fetchall()
    for itm in result:
        data = {'borrow_detailid': itm[0], 'borrowdate': itm[1], 'Autonum': itm[2], 'bookname': itm[3],
                'barcode': itm[4], 'status': itm[5]}
        js.append(data)
    return jsonify(js)


@app.route('/return_all', methods=['POST'])
def return_all():
    js = []
    cur.execute('SELECT * FROM return_all')
    result = cur.fetchall()
    for itm in result:
        data = {'returnid': itm[0], 'returndate': itm[1], 'fee': itm[2], 'staffname': itm[3],
                'studentname': itm[4]}
        js.append(data)
    return jsonify(js)


@app.route('/return_detail_all', methods=['POST'])
def return_detail_all():
    js = []
    cur.execute('SELECT * FROM return_all')
    result = cur.fetchall()
    for itm in result:
        data = {'return_detailid': itm[0], 'returnid': itm[1], 'booname': itm[2], 'barcode': itm[3],
                'fine': itm[4], 'lateday': itm[5], 'borrowid': itm[6]}
        js.append(data)
    return jsonify(js)


# ----------------------------------------------------------------------------------------------------------------------------------
# -------------------------------------------------------------Delete---------------------------------------------------------------


def delete(obj):
    db.session.delete(obj)
    db.session.commit()


def getDataDelete(jsonData, Table):
    for itm in jsonData:
        id = itm.get('id')
        query = Table.query.get(id)
        delete(query)


@app.route('/staff_delete', methods=['POST'])
def staff_delete():
    getDataDelete(requesJson(), Staff)
    return staff_all()


@app.route('/user_delete', methods=['POST'])
def user_delete():
    getDataDelete(requesJson(), User)
    return user_all()


@app.route('/role_delete', methods=['POST'])
def role_delete():
    getDataDelete(requesJson(), Role)
    return role_all()


@app.route('/privillage_delete', methods=['POST'])
def privillage_delete():
    getDataDelete(requesJson(), Privillage)
    return privillage_all()


@app.route('/student_delete', methods=['POST'])
def student_delete():
    getDataDelete(requesJson(), Student)
    return student_all()


@app.route('/printcrad_delete', methods=['POST'])
def printcard_delete():
    getDataDelete(requesJson(), Printcard)
    return printcard_all()


@app.route('/print_detail_delete', methods=['POST'])
def print_detail_delete():
    getDataDelete(requesJson(), Printcard_details)
    return print_detail_all


@app.route('/book_delete', methods=['POST'])
def book_delete():
    getDataDelete(requesJson(), Book)
    return book_all()


@app.route('/catagory_delete', methods=['POST'])
def catagory_delete():
    getDataDelete(requesJson(), Catagory)
    return catagory_all()


@app.route('/collect_delete', methods=['POST'])
def collect_delete():
    getDataDelete(requesJson(), Collect)
    return collect_all()


@app.route('/collect_detail_delete', methods=['POST'])
def collect_detail_delete():
    getDataDelete(requesJson(), Collect_details)
    return collect_detail_all()


@app.route('/collect_type_delete', methods=['POST'])
def collect_type_delete():
    getDataDelete(requesJson(), Collecttype)
    return collect_type_all()


@app.route('/expense_delete', methods=['POST'])
def expense_delete():
    getDataDelete(requesJson(), Expense)
    return expense_all()


@app.route('/expense_detail_delete', methods=['POST'])
def expense_detail_delete():
    getDataDelete(requesJson(), Expense_deltails)
    return expense_detail_all()


@app.route('/expense_type_delete', methods=['POST'])
def expense_type_delete():
    getDataDelete(requesJson(), Expense_type)
    return expense_type_all()


@app.route('/import_delete', methods=['POST'])
def import_delete():
    getDataDelete(requesJson(), Import)
    return import_all()


@app.route('/import_detail_delete', methods=['POST'])
def import_detail_delete():
    getDataDelete(requesJson(), Import_details)
    return import_detail_all()


@app.route('/importbook_delete', methods=['POST'])
def importbook_delete():
    getDataDelete(requesJson(), Importbook)
    return importbook_all()


@app.route('/supplier_delete', methods=['POST'])
def supplier_delete():
    getDataDelete(requesJson(), Supplier)
    return supplier_all()


@app.route('/stock_delete', methods=['POST'])
def stock_delete():
    getDataDelete(requesJson(), Stock)
    return stock_all()


@app.route('/borrow_delete', methods=['POST'])
def borrow_delete():
    getDataDelete(requesJson(), Borrow)
    return borrow_all()


@app.route('/borrow_detail_delete', methods=['POST'])
def borrow_detail_delete():
    getDataDelete(requesJson(), Borrow_details)
    return borrow_detail_all()


@app.route('/return_delete', methods=['POST'])
def return_delete():
    getDataDelete(requesJson(), Return)
    return return_all


@app.route('/return_detail_delete', methods=['POST'])
def return_detail_deete():
    getDataDelete(requesJson(), Return_details)
    return return_detail_all()

# ----------------------------------------------------------------------------------------------------------------------------------
# -------------------------------------------------------------Update---------------------------------------------------------------
#
# def update():
#     db.session.commit()
#
#
# @app.route('/staff_update', methods=['POST'])
# def staff_update():
#     # name, sex, dob, phone, email, address, photo
#     id=requesJson()['id']
#
#
#
#
# @app.route('/user_add', methods=['POST'])
# def user_add():
#     # name, passwd, is_active, staffid, roleid
#     for itm in requesJson():
#         name = itm.get('name')
#         passwd = itm.get('passwd')
#         is_active = itm.get('active')
#         staffid = itm.get('staffid')
#         roleid = itm.get('roleid')
#         me = User(name, passwd, is_active, staffid, roleid)
#         Add(me)
#         return me.userid + 'inserted success !'
#
#
# @app.route('/role_add', methods=['POST'])
# def role_add():
#     for itm in requesJson():
#         name = itm.get('name')
#         privillageid = itm.get('privillageid')
#         me = Role(name, privillageid)
#         Add(me)
#         return me.roleid + 'inserted Success !'
#
#
# @app.route('/privillage_add', methods=['POST'])
# def privillage_add():
#     for itm in requesJson():
#         name = itm.get('name')
#         me = Privillage(name)
#         Add(me)
#         return me.privillageid + 'inserted Success !'
#
#
# @app.route('/student_add', methods=['POST'])
# def student_add():
#     #     name, sex, dob, phone, email, address, photo, creatDate, CreatBy
#     for itm in requesJson():
#         name = itm.get('name')
#         sex = itm.get('sex')
#         dob = itm.get('dob')
#         phone = itm.get('phone')
#         email = itm.get('email')
#         address = itm.get('address')
#         photo = itm.get('photo')
#         createDate = itm.get('createDate')
#         Createby = itm.get('createBy')
#         me = Student(name, sex, dob, phone, email, address, photo, createDate, Createby)
#         Add(me)
#         return me.studentid + 'inserted Success !'
#
#
# @app.route('/printcrad_add', methods=['POST'])
# def printcard_add():
#     for itm in requesJson():
#         printDate = itm.get('printDate')
#         total = itm.get('total')
#         Createby = itm.get('Creatby')
#         me = Printcard(printDate, total, Createby)
#         Add(me)
#         return me.printid
#
#
# @app.route('/print_detail_add', methods=['POST'])
# def print_detail_add():
#     for itm in requesJson():
#         printcardid = itm.get('printcardid')
#         cardid = itm.get('cardid')
#         ExpireDate = itm.get('ExpireDate')
#         Autonum = itm.get('Autonum')
#         bookQty = itm.get('bookQty')
#         price = itm.get('price')
#         studenid = itm.get('studenid')
#         me = Printcard_details(printcardid, cardid, ExpireDate, Autonum, bookQty, price, studenid)
#         Add(me)
#         return me.printcardDid
#
#
# @app.route('/book_add', methods=['POST'])
# def book_add():
#     # bookname, borrowprice, fineperday, Quantity, Creatby, CreatDate, Author, Catagoryid, photo
#     for itm in requesJson():
#         bname = itm.get('name')
#         borrowprice = itm.get('price')
#         finepereday = itm.get('fine')
#         Quantity = itm.get('qty')
#         Creatby = itm.get('createby')
#         CreatDate = itm.get('cratedate')
#         Author = itm.get('author')
#         Catagoryid = itm.get('catagoryid')
#         photo = itm.get('photo')
#         me = Book(bname, borrowprice, finepereday, Quantity, Creatby, CreatDate, Author, Catagoryid, photo)
#         Add(me)
#         return me.bookid + 'inserted Success !'
#
#
# @app.route('/catagory_add', methods=['POST'])
# def catagory_add():
#     for itm in requesJson():
#         name = itm.get('name')
#         me = Catagory(name)
#         Add(me)
#         return me.catId + 'inserted Success !'
#
#
# @app.route('/collect_add', methods=['POST'])
# def collect_add():
#     for itm in requesJson():
#         date = itm.get('date')
#         total = itm.get('total')
#         fromdate = itm.get('fromdate')
#         todate = itm.get('todate')
#         collectby = itm.get('collectby')
#         me = Collect(date, total, fromdate, todate, collectby)
#         Add(me)
#         return me.collectid
#
#
# @app.route('/collect_detail_add', methods=['POST'])
# def collect_detail_add():
#     for itm in requesJson():
#         id = itm.get('id')
#         subtotal = itm.get('subtotal')
#         collecttypeid = itm.get('typeid')
#         me = Collect_details(id, subtotal, collecttypeid)
#         Add(me)
#         return me.collectdid
#
#
# @app.route('/collect_type_add', methods=['POST'])
# def collect_type_add():
#     for itm in requesJson():
#         collecttype = itm.get('type')
#         me = Collecttype(collecttype)
#         Add(me)
#         return me.collecttypeid
#
#
# @app.route('/expense_add', methods=['POST'])
# def expense_add():
#     for itm in requesJson():
#         date = itm.get('date')
#         total = itm.get('total')
#         createby = itm.get('createby')
#         me = Expense(date, total, createby)
#         Add(me)
#         return me.expenseid
#
#
# @app.route('/expense_detail_add', methods=['POST'])
# def expense_detail_add():
#     for itm in requesJson():
#         id = itm.get('id')
#         amount = itm.get('amount')
#         expensetype = itm.get('type')
#         me = Expense_deltails(id, amount, expensetype)
#         Add(me)
#         return me.expenseDid
#
#
# @app.route('/expense_type_add', methods=['POST'])
# def expense_type_add():
#     for itm in requesJson():
#         name = itm.get('name')
#         me = Expense_type(name)
#         Add(me)
#         return me.expenseTid
#
#
# @app.route('/import_add', methods=['POST'])
# def import_add():
#     for itm in requesJson():
#         desc = itm.get('desc')
#         date = itm.get('date')
#         total = itm.get('total')
#         staff = itm.get('staff')
#         supplier = itm.get('supplier')
#         me = Import(desc, date, total, staff, supplier)
#         Add(me)
#         return me.importid
#
#
# @app.route('/import_detail_add', methods=['POST'])
# def import_detail_add():
#     for itm in requesJson():
#         autonum = itm.get('autonum')
#         qty = itm.get('qty')
#         cost = itm.get('cost')
#         subtotal = itm.get('subtotal')
#         bookid = itm.get('bookid')
#         importid = itm.get('importid')
#         me = Import_details(autonum, qty, cost, subtotal, bookid, importid)
#         Add(me)
#         return me.importDid
#
#
# @app.route('/importbook_add', methods=['POST'])
# def importbook_add():
#     for itm in requesJson():
#         importid = itm.get('importid')
#         barcode = itm.get('barcode')
#         importDid = itm.get('importDid')
#         me = Importbook(importid, barcode, importDid)
#         Add(me)
#         return me.importbookid
#
#
# @app.route('/supplier_add', methods=['POST'])
# def supplier_add():
#     for itm in requesJson():
#         name = itm.get('name')
#         phone = itm.get('phone')
#         email = itm.get('email')
#         address = itm.get('address')
#         createdate = itm.get('createdate')
#         createby = itm.get('createby')
#         me = Supplier(name, phone, email, address, createdate, createby)
#         Add(me)
#         return me.supid
#
#
# @app.route('/stock_add', methods=['POST'])
# def stock_add():
#     for itm in requesJson():
#         detailid = itm.get('detailid')
#         autonum = itm.get('autonum')
#         status = itm.get('status')
#         me = Stock(detailid, autonum, status)
#         Add(me)
#         return me.stockid
#
#
# @app.route('/borrow_add', methods=['POST'])
# def borrow_add():
#     for itm in requesJson():
#         date = itm.get('date')
#         datereturn = itm.get('returndate')
#         total = itm.get('total')
#         staffid = itm.get('staffid')
#         studentid = itm.get('studentid')
#         cardid = itm.get('cardid')
#         me = Borrow(date, datereturn, total, staffid, studentid, cardid)
#         Add(me)
#         return me.borrowid
#
#
# @app.route('/borrow_detail_add', methods=['POST'])
# def borrow_detail_add():
#     for itm in requesJson():
#         autonum = itm.get('autonum')
#         bookid = itm.get('bookid')
#         barcode = itm.get('barcode')
#         status = itm.get('status')
#         me = Borrow_details(autonum, bookid, barcode, status)
#         Add(me)
#         return me.borrowDId
#
#
# @app.route('/return_add', methods=['POST'])
# def return_add():
#     for itm in requesJson():
#         returndate = itm.get('returndate')
#         fee = itm.get('fee')
#         staffid = itm.get('staffid')
#         studentid = itm.get('studentid')
#         me = Return(returndate, fee, staffid, studentid)
#         Add(me)
#         return me.returnid
#
#
# @app.route('/return_detail_add', methods=['POST'])
# def return_detail_add():
#     for itm in requesJson():
#         id = itm.get('returnid')
#         bookid = itm.get('bookid')
#         barcode = itm.get('barcode')
#         fine = itm.get('fine')
#         lateday = itm.get('lateday')
#         borrowid = itm.get('borrowid')
#         me = Return_details(id, bookid, barcode, fine, lateday, borrowid)
#         Add(me)
#         return me.returnDid
#

@app.route('/login',methods=['POST'])
def login():
	username=requesJson()['name']
	passwd=requesJson()['passwd']
	cur.execute('select * from user_all where username=%s AND password=%s AND is_active=%s',[username,passwd,'Active'])
	result=cur.fetchall()
	js=[]
	for itm in result:
		data = {'userid': itm[0], 'username': itm[1], 'password': itm[2], 'is_Active': itm[3], 'staffname': itm[4],
		        'rolename': itm[5]}
		js.append(data)
	return jsonify(js)
    
    
        

if __name__ == "__main__":
    app.run()
