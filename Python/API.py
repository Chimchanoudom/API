from flask import Flask, jsonify, request
from flask_sqlalchemy import SQLAlchemy, inspect
from flask_sqlalchemy_session import flask_scoped_session
from sqlalchemy import MetaData, create_engine
from sqlalchemy.orm import sessionmaker

app = Flask(__name__)
engine = create_engine('postgresql://postgres:root@localhost/API')
app.config['SQLALCHEMY_DATABASE_URI'] = 'postgresql://postgres:root@localhost/API'
app.config['SQLALCHEMY_ECHO'] = True
SQLALCHEMY_TRACK_MODIFICATIONS = True
app.debug = True
session_factory = sessionmaker(bind=engine)
session = flask_scoped_session(session_factory, app)
db = SQLAlchemy(app)


# ----------------Model-----------------------------------------------------------

class Catagory(db.Model):
    catId = db.Column(db.Integer, primary_key=True)
    catName = db.Column(db.String(255))
    book = db.relationship('Book', backref='catagory', lazy=True)

    def __init__(self, name):
        self.catName = name


class Book(db.Model):
    bookid = db.Column(db.Integer, primary_key=True)
    bookname = db.Column(db.String(255))
    borrowprice = db.Column(db.Float)
    finePerDay = db.Column(db.Float)
    quantity = db.Column(db.Integer)
    Creatby = db.Column(db.Integer)
    CreatDate = db.Column(db.DateTime)
    Author = db.Column(db.String(255))
    Categoryid = db.Column(db.Integer, db.ForeignKey('catagory.catId'), onupdate='CASCADE',
                           nullable=False)
    photo = db.Column(db.LargeBinary)
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
    borrowid = db.Column(db.Integer, db.ForeignKey('borrow.borrowid'), onupdate='CASCADE', nullable=False)
    AutoNum = db.Column(db.Integer)
    Bookid = db.Column(db.Integer, db.ForeignKey('book.bookid'), onupdate='CASCADE', nullable=False)
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
    borrowDate = db.Column(db.DateTime)
    dateReturn = db.Column(db.DateTime)
    total = db.Column(db.Float)
    staffid = db.Column(db.Integer, db.ForeignKey('staff.staffid'), onupdate='CASCADE',
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
    returnDate = db.Column(db.DateTime)
    fee = db.Column(db.Float)
    staffid = db.Column(db.Integer, db.ForeignKey('staff.staffid'), onupdate='CASCADE',
                        nullable=False)
    studentid = db.Column(db.Integer, db.ForeignKey('student.studentid'), onupdate='CASCADE',
                          nullable=False)
    return_details = db.relationship('Return_details', backref='return', lazy=True)

    def __init__(self, returnDate, fee, staffid, studentid):
        self.returnDate = returnDate
        self.fee = fee
        self.staffid = staffid
        self.studentid = studentid


class Return_details(db.Model):
    returnDid = db.Column(db.Integer, primary_key=True)
    returnid = db.Column(db.Integer, db.ForeignKey('return.returnid'), onupdate='CASCADE',
                         nullable=False)
    bookid = db.Column(db.Integer, db.ForeignKey('book.bookid'), onupdate='CASCADE', nullable=False)
    barcode = db.Column(db.String(255))
    fine = db.Column(db.Float)
    lateDay = db.Column(db.Integer)
    borrowid = db.Column(db.Integer, db.ForeignKey('borrow_details.borrowDId'), onupdate='CASCADE',
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
    DateOfbirth = db.Column(db.DateTime)
    phone = db.Column(db.String(255))
    email = db.Column(db.String(255))
    Address = db.Column(db.String(255))
    photo = db.Column(db.LargeBinary)
    CreatDate = db.Column(db.DateTime)
    Creatby = db.Column(db.Integer, db.ForeignKey('staff.staffid'), onupdate='CASCADE',
                        nullable=False)
    printcard = db.relationship('Printcard_Details', backref='student', lazy=True)

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
    printDate = db.Column(db.DateTime)
    total = db.Column(db.Integer)
    Creatby = db.Column(db.Integer, db.ForeignKey('staff.staffid'), onupdate='CASCADE',
                        nullable=False)
    printCard_Details = db.relationship('Printcard_details', backref='printcard', lazy=True)

    def __init__(self, printDate, total, Creatby):
        self.printDate = printDate
        self.total = total
        self.Creatby = Creatby


class Printcard_details(db.Model):
    printcardDid = db.Column(db.Integer, primary_key=True)
    printcardid = db.Column(db.Integer, db.ForeignKey('printcard.printid'), onupdate='CASCADE',
                            nullable=False)
    cardid = db.Column(db.String(255))
    ExpireDate = db.Column(db.DateTime)
    AutoNum = db.Column(db.Integer)
    bookQuantity = db.Column(db.Integer)
    price = db.Column(db.Float)
    studentid = db.Column(db.Integer, db.ForeignKey('student.studentid'), onupdate='CASCADE',
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
    DateOfbirth = db.Column(db.DateTime)
    phone = db.Column(db.String(255))
    email = db.Column(db.String(255))
    Address = db.Column(db.String(255))
    photo = db.Column(db.LargeBinary)
    printcard = db.relationship('Printcard', backref='staff', lazy=True)
    student = db.relationship('Student', backref='staff', lazy=True)
    expense = db.relationship('Expense', backref='staff', lazy=True)
    collect = db.relationship('Collect', backref='staff', lazy=True)
    borrow = db.relationship('Borrow', backref='staff', lazy=True)
    returnbook = db.relationship('Return', backref='staff', lazy=True)
    Import = db.relationship('Import', backref='staff', lazy=True)
    supplire = db.relationship('Supplire', backref='staff', lazy=True)
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
    CreatDate = db.Column(db.DateTime)
    Creatby = db.Column(db.Integer, db.ForeignKey('staff.staffid'), onupdate='CASCADE',
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
    importDate = db.Column(db.DateTime)
    total = db.Column(db.Float)
    CreatBy = db.Column(db.Integer, db.ForeignKey('staff.staffid'), onupdate='CASCADE',
                        nullable=False)
    supid = db.Column(db.Integer, db.ForeignKey('supplier.supid'), onupdate='CASCADE',
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
    bookid = db.Column(db.Integer, db.ForeignKey('book.bookid'), onupdate='CASCADE',
                       nullable=False)
    importid = db.Column(db.Integer, db.ForeignKey('import.importid'), onupdate='CASCADE',
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
    importid = db.Column(db.Integer, db.ForeignKey('import.importid'), onupdate='CASCADE',
                         nullable=False)
    bacode = db.Column(db.String(255))
    importdetailid = db.Column(db.Integer, db.ForeignKey('import_details.importDid'), onupdate='CASCADE',

                               nullable=False)

    def __init__(self, importid, barcode, importDid):
        self.importid = importid
        self.bacode = barcode
        self.importdetailid = importDid


class Stock(db.Model):
    stockid = db.Column(db.Integer, primary_key=True)
    importdetailid = db.Column(db.Integer, db.ForeignKey('import_details.importDid'), onupdate='CASCADE',
                               nullable=False)
    autonum = db.Column(db.Integer)
    Status = db.Column(db.Integer)

    def __init__(self, detailid, autonum, status):
        self.importdetailid = detailid
        self.autonum = autonum
        self.Status = status


class Expense(db.Model):
    expenseid = db.Column(db.Integer, primary_key=True)
    expenseDate = db.Column(db.DateTime)
    total = db.Column(db.Float)
    CreateBy = db.Column(db.Integer, db.ForeignKey('staff.staffid'), onupdate='CASCADE',
                         nullable=False)
    expense_details = db.relationship('Expense_deltails', backref='expense', lazy=True)

    def __init__(self, date, total, createby):
        self.expenseDate = date
        self.total = total
        self.CreateBy = createby


class Expense_deltails(db.Model):
    expenseDid = db.Column(db.Integer, primary_key=True)
    expenseid = db.Column(db.Integer, db.ForeignKey('expense.expenseid'), onupdate='CASCADE',
                          nullable=False)
    amount = db.Column(db.Float)
    expenseType = db.Column(db.Integer, db.ForeignKey('expense_type.expenseTid'), onupdate='CASCADE',
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
    privillageid = db.Column(db.Integer, db.ForeignKey('privillage.privillageid'), onupdate='CASCADE',
                             nullable=False)
    User = db.relationship('User', backref='role', lazy=True)

    def __init__(self, rolename, privilageid):
        self.rolename = rolename
        self.privillageid = privilageid


class User(db.Model):
    userid = db.Column(db.Integer, primary_key=True)
    username = db.Column(db.String(255))
    password = db.Column(db.String(255))
    is_active = db.Column(db.String(10))
    staffid = db.Column(db.Integer, db.ForeignKey('staff.staffid'), onupdate='CASCADE',
                        nullable=False)
    roleid = db.Column(db.Integer, db.ForeignKey('role.roleid'), onupdate='CASCADE',
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
    collectid = db.Column(db.Integer, db.ForeignKey('collect.collectid'), onupdate='CASCADE',
                          nullable=False)
    subtotal = db.Column(db.Float)
    collecttypeid = db.Column(db.Integer, db.ForeignKey('collecttype.collecttypeid'), onupdate='CASCADE',
                              nullable=False)

    def __init__(self, collectid, subtotal, collecttypeid):
        self.collectdid = collectid
        self.subtotal = subtotal
        self.collecttypeid = collecttypeid


class Collect(db.Model):
    collectid = db.Column(db.Integer, primary_key=True)
    collectDate = db.Column(db.DateTime)
    total = db.Column(db.Float)
    fromDate = db.Column(db.DateTime)
    todate = db.Column(db.DateTime)
    Collectby = db.Column(db.Integer, db.ForeignKey('staff.staffid'), onupdate='CASCADE',
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

if __name__ == "__main__":
    app.run()