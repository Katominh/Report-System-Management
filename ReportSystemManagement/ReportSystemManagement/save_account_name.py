import sys

oldName = sys.argv[1]
newname = sys.argv[2]
accounts = []
FILENAME = "..\\..\\login_accounts.txt"
DELIMITER = "|||"

def main():
    loadAccounts()
    for each in accounts:
        if each[2] == oldName: each[2] = newname
    saveAccounts()
    updateAllNamesRecord()

# Get a list of accounts
def loadAccounts():
    with open(FILENAME, "r") as f:
        content = f.readlines()
        for line in content:
            accounts.append(line.strip().split(DELIMITER))

# Save the list of account to text file
def saveAccounts():
    with open(FILENAME, "w") as f:
        for account in accounts:
            f.write(DELIMITER.join(account) + "\n")

# Update the text records with the new name too
def updateAllNamesRecord():
    allRecords = []

    # Reading all records (+ header)
    with open("..\\..\\report_records.txt", "r") as f:
        content = f.readlines()
        for line in content:
            record = line.strip().split(DELIMITER)
            if record[1] == oldName:
                record[1] = newname     # Update student name
                record[16] = newname    # Update declaration name
            allRecords.append(record)
    
    # Writing all records (+ header)
    with open("..\\..\\report_records.txt", "w") as f:
        for eachRecord in allRecords:
            f.write(DELIMITER.join(eachRecord) + "\n")



main()