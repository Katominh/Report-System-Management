import sys

usr = sys.argv[1]
passwd = sys.argv[2]
admin = {"admin": "1234567890"}
students = {
    "student1": "1234567890",
    "student2": "1234567890",
    "student3": "1234567890"
}

def checkAdmin():
    for n, p in admin.items():
        if n == usr and p == passwd:
            print("Admin", end="")

def checkStudent():
    for n, p in students.items():
        if n == usr and p == passwd:
            print("Student", end="")

checkAdmin()
checkStudent()
