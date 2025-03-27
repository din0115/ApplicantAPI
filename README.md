# Applicant API Testing Guide

## Testing Frameworks and Tools
- **Postman**
- **Swagger**

---

## Test Cases

### 1. Save/Update Applicant
#### i. Add a new applicant when no ID is provided.
- **Input:** Valid `AddApplicantDto` without `id`
- **Expected Result:**
  - Applicant is added.
  - Response: `200 OK`
  - Message: `"Your Data has been added successfully!"`

#### ii. Update an existing applicant when a valid ID is provided.
- **Input:** Valid `AddApplicantDto` with existing `id`
- **Expected Result:**
  - Applicant is updated.
  - Response: `200 OK`
  - Message: `"Your Data has been updated successfully!"`

#### iii. Attempt to update a non-existent applicant
- **Input:** Valid `AddApplicantDto` with non-existent `id`
- **Expected Result:**
  - Response: `404 Not Found`
  - Message: `"This ID doesn't exist"`

#### iv. Invalid data in `AddApplicantDto`
- **Input:** Missing required fields like `FirstName`, `Email`, or `LastName`.
- **Note:** To send `Github` and `Linkedin` as `null`, remove the column name from the request body.
- **Expected Result:**
  - Response: `400 Bad Request`

---

### 2. Get All Applicants
#### i. Retrieve all applicants when the database is populated.
- **Expected Result:**
  - Returns a list of all applicants.

#### ii. Retrieve all applicants when the database is empty.
- **Expected Result:**
  - Returns an empty list.

---

### 3. Get Applicant by ID
#### i. Retrieve an applicant by valid ID.
- **Input:** Valid `id`
- **Expected Result:**
  - Returns the applicant's details.

#### ii. Retrieve an applicant by invalid ID.
- **Input:** Non-existent `id`
- **Expected Result:**
  - Response: `404 Not Found`
  - Message: `"This ID doesn't exist"`

---

### 4. Delete Applicant
#### i. Delete an applicant by valid ID.
- **Input:** Valid `id`
- **Expected Result:**
  - Applicant is deleted.
  - Response: `200 OK`
  - Message: `"ApplicantName delete successful."`

#### ii. Attempt to delete a non-existent applicant.
- **Input:** Non-existent `id`
- **Expected Result:**
  - Response: `404 Not Found`
  - Message: `"This ID doesn't exist"`

---

## Notes
- Ensure the API is running before executing tests.
- Use Postman to send requests and verify responses.
- Swagger can be used for API documentation and testing.

