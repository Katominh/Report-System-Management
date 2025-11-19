import time
import sys 
import os

FILENAME = "..\\..\\report_records.txt"
DELIMITER = "|||"
CHOICE_MODE = int(sys.argv[1])
MAIN_DATA = sys.argv[2] # Often is the entire line of student's input
EXTRA_DATA = sys.argv[3]
CURRENT_RECORD_ID = "0"
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
    global RECORDS
     # Load existing records from file
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

# Generate a unique ID based on current time
def getId():
    CURRENT_RECORD_ID = str(int(time.time()))
    print(CURRENT_RECORD_ID)

# Add a new case report to the file
def addCaseReport():
    userInputs = MAIN_DATA
    id = MAIN_DATA.split(DELIMITER)[0]  
    if searchRecord(id) != -1:
        saveRecord()
        return
    with open(FILENAME, "a", encoding="utf-8") as f:
        f.write(userInputs + "\n")
    print("Add Done.", end="")

# Return index of the record found in RECORDS list
def searchRecord(targetID):

    for eachRecord in RECORDS:
        if eachRecord[0] == str(targetID):
            return RECORDS.index(eachRecord)
    print("Target record", targetID, "not found.", end="")
    return -1

# Delete a record from the file
def deleteRecord():
    id = MAIN_DATA.split(DELIMITER)[0]
    indexLocation = searchRecord(id)
    
    # We'll delete this record in RECORDS
    if indexLocation == -1:
        print("Delete Failed", end="")
        return
    RECORDS.pop(indexLocation)
    if len(RECORDS) == 0:
        # If no records left, just recreate the file with headers
        createFile()
        print("Delete Done", end="")
        return
    # Then overwrite the text file with the new RECORDS (Because there's no way to shift lines of text up or dowb=n)
    with open(FILENAME, "w", encoding="utf-8") as f:
        f.write(DELIMITER.join(SHORT_KEYS) + "\n") # Write headers
        for i, record in enumerate(RECORDS):
            if i != indexLocation:
                f.write(DELIMITER.join(record) + "\n")
    print("Delete Done", end="")

def saveRecord():
    id = MAIN_DATA.split(DELIMITER)[0]

    indexLocation = searchRecord(id)
    # We'll then overwrite the old record with the new record data from MAIN_INPUT
    if indexLocation == -1:
        print("Save Failed", end="")
        return
    newRecord = MAIN_DATA.split(DELIMITER)
    RECORDS[indexLocation] = newRecord
    # Then overwrite the text file with the new RECORDS
    with open(FILENAME, "w", encoding="utf-8") as f:
        f.write(DELIMITER.join(SHORT_KEYS) + "\n") # Write headers
        for record in RECORDS:
            f.write(DELIMITER.join(record) + "\n")
    print("Save Done", end="")
    


#===========================================================================
# Supporting functions
#===========================================================================
def createFile():
    if len(RECORDS) == 0: # If empty
        with open(FILENAME, "w", encoding="utf-8") as f:
            f.write(DELIMITER.join(SHORT_KEYS) + "\n") # Just write headers

# Load all records from file into RECORDS list
def loadRecords(): # Return everything from file
    records = []
    with open(FILENAME, "r", encoding="utf-8") as f:
        lines = f.readlines()
        if not lines: return []
        for line in lines[1:]:
            records.append(line.strip().split(DELIMITER))
    return records
   
    
main()

