import sys

usr = sys.argv[1]
passwd = sys.argv[2]
admin = []
students = []
isValid = False
DELIMITER = "|||"

def readLoginAccount():
    global admin, students
    with open("..\\..\\login_accounts.txt", "r") as f:
        admin = f.readline().strip().split(DELIMITER)

        for i in range(3):
            students.append(f.readline().strip().split(DELIMITER))

def checkAdmin():
    global isValid
    u, p, id = admin
    if u == usr and p == passwd:
        print("Admin" + id, end="")
        isValid = True

def checkStudent():
    global isValid
    for u, p, id in students:
        if u == usr and p == passwd:
            print("Student" + id, end="")
            isValid = True

# Prevent crashing if input less than 5 letter long
def checkInputLength():
    if len(usr) < 5:
        validate()

def validate():
    if not isValid:
        print("Invalid", end="")
        return

checkInputLength()
readLoginAccount()
checkAdmin()
checkStudent()
validate()