import time
import sys 
import os

FILENAME = "..\\..\\report_records.txt"
DELIMITER = "|||"
CHOICE_MODE = int(sys.argv[1])
MAIN_DATA = sys.argv[2].split(DELIMITER) # Often is the entire line of student's input
EXTRA_DATA = sys.argv[3].split(DELIMITER)
CURRENT_ID = "0"
RECORDS = []
SHORT_KEYS = [ # for dictionary keys
    "StudentName", "StudentNumber", "StudentEmail", "FacultyName", "ReportDate",
    "CourseInfo", "AssignmentInfo", "Department", "Term",
    "ViolationDesc",
    "StudentSupportNotice",
    "StudentStatementNotice",
    "FacSignature1", "FacName1", "FacDate1",
    "StudentAwareDeclaration",
    "StudentReviewedDeclaration",
    "StudentTRUEmail", "StudentSignature", "StudentDate",
    "FacSignature2", "FacName2", "FacDate2",
    "StudentAgreement1", "StudentDisagreeReason1", "StudentComments1",
    "ChairSignature", "ChairName", "ChairDate",
    "StudentAgreement2", "StudentDisagreeReason2", "StudentComments2",
    "DeanSignature", "DeanName", "DeanDate",
    "FacComments", "StudentComments"
]

# ===============================
# Main Menu Function
# ===============================
def main():
    if not os.path.exists(FILENAME): createFile() # create file
    else:
        RECORDS = loadRecords()

    match CHOICE_MODE:
        case 0:
            getId()
        case 1:
            addCaseReport()
        case 2: 
            searchRecord()
        case 3:
            deleteRecord()
        case 4:
            saveRecord()
        case _:
            print("Invalid Choice Mode", CHOICE_MODE, end="")

# ===============================
# Key Functions
# ===============================

def getId():
    CURRENT_ID = str(int(time.time()))
    print(CURRENT_ID, end="")

def addCaseReport():
    userInputs = CURRENT_ID + (DELIMITER * 37) # Blank inputs for now
    with open(FILENAME, "w", encoding="utf-8") as f:
        f.write(userInputs + "\n")
    print("Add Done", end="")

def searchRecord(records):
    print("Search Done", end="")


def deleteRecord():
    print("Delete Done", end="")

def saveRecord():
    print("Save Done", end="")


#===========================================================================
# Supporting functions
#===========================================================================
def createFile():
    if len(RECORDS) == 0: # If empty
        with open(FILENAME, "w", encoding="utf-8") as f:
            f.write(DELIMITER.join(SHORT_KEYS) + "\n") # Just write headers

def loadRecords(): # Return everything from file
    records = []

    with open(FILENAME, "r", encoding="utf-8") as f:
        lines = f.readlines()
        if not lines: return []

        for line in lines[1:]:
            records.append(line.strip().split(DELIMITER))
    
    return records
    
main()