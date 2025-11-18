import sys

usr = sys.argv[1]
passwd = sys.argv[2]
admin = {"adminKelvin Hart": "1234567890"}
students = {
    "student1John Ward": "1234567890",
    "student2Nathan Gale": "1234567890",
    "student3Garcia": "1234567890"
}

def checkAdmin():
    for n, p in admin.items():
        if n[:5] == usr and p == passwd:
            print("Admin" + n[5:], end="")

def checkStudent():
    for n, p in students.items():
        if n[:8] == usr and p == passwd:
            print("Student" + n[8:], end="")

checkAdmin()
checkStudent()
