# time-sprout
Daily time record written in C# using winforms library and sqlite database
- it is an stand alone software that can be used in taking and storing daily time record of employees.


# employee
- create table [employees]
- crud
- c => create new employee by filling in all of the fields
- r => read all employees and show in [employees form]
- u => update employees [can be done in employees form]
- d => delete employee using their id [each employee has unique id]
- error check: prevent adding if id is already taken


# time record
- create a table [record_currentdate]
- insert all employees on that new table
- set all the values on each field to '-' [underscore]
- the employee or admin can edit it with button click [on time record form]
- the time will be generated automatically based on the time they pressed the button
- add restriction [ie. prohibit time in on am(11:59 and down] if it is already pm(12:00 and up)]
- 