# test

## Spring Boot Application for List View

This Spring Boot application provides a list view with search functionality. The list view consists of a search input area at the top of the page and a table displaying the search results below it. The search results are displayed as a list with pagination controls.

### How to Run the Application

1. Clone the repository.
2. Open the project in your preferred IDE.
3. Build the project using Maven or Gradle.
4. Run the application.
5. Open a web browser and navigate to `http://localhost:8080/list`.

### Examples

#### Valid Input

```
Search: example
Results:
ID   Name     Description
1    Name 1   Description 1
2    Name 2   Description 2
...
10   Name 10  Description 10
```

#### Invalid Input

```
Search: 
Results:
No results found.
```
