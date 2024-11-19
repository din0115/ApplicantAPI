

1. Testing Frameworks and Tools
  PostMan
  Swagger
2. Test Cases
SaveUpdate Applicant
   i.Add a new applicant when no id is provided.
     Input: Valid AddApplicantDto without id
     Expected Result: Applicant is added, and the response is 200 OK"Your Data has been added successfully!").
   ii.Update an existing applicant when a valid id is provided.
        Input: Valid AddApplicantDto with existing id.
        Expected Result: Applicant is updated, and the response is 200 OK"Your Data has been updated successfully!").
   iii.Attempt to update a non-existent applicant
       Input: Valid AddApplicantDto with non-existent id.
        Expected Result: Response is 404 Not Found(This ID doesn't exist).
   iv. Invalid data in AddApplicantDto.
         Input: Missing required fields like FirstName or Email or LastName .To send Github and Linkedin null remove the colmun name from request body.
        Expected Result: Response is 400 Bad Request.

   Get All Applicants
       i. Retrieve all applicants when the database is populated.
         Expected Result: Returns a list of all applicants.
       ii. Retrieve all applicants when the database is empty.
           Expected Result: Returns an empty list.

    Get Applicant By ID
     i.Retrieve an applicant by valid id.
         Input: Valid id
         Expected Result: Returns the applicant's details.
     ii. Retrieve an applicant by invalid id.
         Input: Non-existent id.
         Expected Result: Response is 404 Not Found(This ID doesn't exist).

      Delete Applicant
       i. Delete an applicant by valid id.
           Input: Valid id.
            Expected Result: Applicant is deleted, and the response is 200 OK("ApplicantName+ delete successfull.").
       ii.  Attempt to delete a non-existent applicant.
           Input: Non-existent id.
             Expected Result: Response is 404 Not Found(This ID doesn't exist).
   
