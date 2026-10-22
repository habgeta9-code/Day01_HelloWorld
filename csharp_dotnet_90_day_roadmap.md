# 90-Day C#/.NET Engineering Roadmap

**Duration:** 90 days  
**Daily commitment:** 90–120 minutes  
**Primary stack:** C#, .NET, ASP.NET Core, EF Core, SQL, Git, GitHub  
**Learning method:** Problem → Design → Implement → Test → Document → Commit

## Daily operating routine

Follow this routine every day:

- [ ] 10 minutes — Review yesterday's lesson and recall what you learned without reading your notes.
- [ ] 15–20 minutes — Study one concept through official documentation or a focused example.
- [ ] 40–50 minutes — Solve the day's programming problem independently.
- [ ] 15–20 minutes — Test, debug, refactor, and explain your solution.
- [ ] 10–15 minutes — Write documentation and commit your progress.

If you need more time to solve a problem, prioritize understanding it over completing every task on schedule.

---

# MONTH 1 — Problem Solving, C# and Object-Oriented Design

**Goal:** Become confident translating real-world problems into algorithms, classes, methods, and tests.

## Week 1 — Problem decomposition and C# practice

### Day 1 — Establish your development environment
- [ ] Verify the .NET SDK, Git, and VS Code.
- [ ] Create a console project named `ProblemSolvingLab`.
- [ ] Create a Git repository and make your first commit.
- [ ] Write your learning objectives in `README.md`.

**Deliverable:** A working project and a documented repository.

### Day 2 — Break problems into smaller steps
- [ ] Solve a temperature conversion problem.
- [ ] Write the inputs, outputs, constraints, and examples before coding.
- [ ] Write pseudocode before implementing the solution.
- [ ] Test normal, minimum, and invalid inputs.

**Deliverable:** `TemperatureConverter.cs` and a problem-analysis note.

### Day 3 — Conditions and decision-making
- [ ] Build a shipping-cost calculator based on weight and destination.
- [ ] Identify all decision branches before coding.
- [ ] Test boundary values and invalid input.
- [ ] Refactor complicated conditions into readable methods.

**Deliverable:** A tested shipping calculator.

### Day 4 — Loops and collections
- [ ] Build a program that analyzes a list of numbers.
- [ ] Calculate the minimum, maximum, average, and sum.
- [ ] Handle an empty collection.
- [ ] Compare a loop-based solution with built-in collection methods.

**Deliverable:** A reusable number-analysis program.

### Day 5 — Methods and decomposition
- [ ] Build a simple expense calculator.
- [ ] Divide the program into small methods with clear responsibilities.
- [ ] Avoid repeating calculation logic.
- [ ] Test each method independently where practical.

**Deliverable:** A program organized into focused methods.

### Day 6 — Dictionaries and counting
- [ ] Build a word-frequency counter.
- [ ] Count how many times each word occurs.
- [ ] Decide how to handle capitalization and punctuation.
- [ ] Test repeated words, empty text, and mixed capitalization.

**Deliverable:** A text-analysis utility.

### Day 7 — Weekly problem-solving assessment
- [ ] Solve a new problem: analyze student scores and assign grades.
- [ ] Write requirements and pseudocode without a tutorial.
- [ ] Implement and test your solution.
- [ ] Document what slowed you down and what you learned.

**Deliverable:** A complete, independently solved problem.

## Week 2 — Learning to think in classes

### Day 8 — Identify classes from requirements
- [ ] Design a library book-management problem.
- [ ] Identify candidate classes, such as `Book`, `Member`, and `Library`.
- [ ] Explain what information and behavior each class owns.
- [ ] Sketch the relationships before writing code.

**Deliverable:** A class-responsibility design document.

### Day 9 — Encapsulation and invariants
- [ ] Implement a `BankAccount` class.
- [ ] Support depositing and withdrawing money.
- [ ] Prevent invalid balances and invalid transaction amounts.
- [ ] Test that invalid operations do not corrupt account state.

**Deliverable:** A `BankAccount` class with tested business rules.

### Day 10 — Constructors and object state
- [ ] Build a `Product` class with required initial values.
- [ ] Prevent invalid product prices and identifiers.
- [ ] Decide which properties should be changeable.
- [ ] Test object creation with valid and invalid data.

**Deliverable:** A class that protects its valid state.

### Day 11 — Responsibilities and collaboration
- [ ] Design an order-processing problem.
- [ ] Separate `Product`, `OrderItem`, and `Order`.
- [ ] Calculate order totals without duplicating logic.
- [ ] Explain why each calculation belongs in its chosen class.

**Deliverable:** A working order model.

### Day 12 — Relationships between objects
- [ ] Model a university with students and courses.
- [ ] Represent enrollment using appropriate objects and collections.
- [ ] Add enrollment and withdrawal operations.
- [ ] Prevent duplicate enrollment.

**Deliverable:** A small university enrollment model.

### Day 13 — Interfaces and polymorphism
- [ ] Model different payment methods.
- [ ] Introduce an `IPaymentMethod` interface.
- [ ] Implement two payment-method classes.
- [ ] Process payments through the interface rather than concrete types.

**Deliverable:** An extensible payment-processing exercise.

### Day 14 — Weekly object-oriented assessment
- [ ] Design a parking-lot system with vehicles, parking spaces, and tickets.
- [ ] Identify class responsibilities before coding.
- [ ] Implement parking and vehicle retrieval.
- [ ] Test full parking lots, duplicate operations, and invalid tickets.
- [ ] Document your design decisions.

**Deliverable:** A small object-oriented parking system.

## Week 3 — Stronger C# design and problem-solving

### Day 15 — Inheritance versus composition
- [ ] Model employees and payroll calculations.
- [ ] Decide whether inheritance or composition better fits the requirements.
- [ ] Implement two employee payment policies.
- [ ] Explain the trade-offs in your documentation.

**Deliverable:** An employee payroll model.

### Day 16 — Generics and reusable code
- [ ] Build a generic in-memory repository.
- [ ] Support adding, finding, and removing items.
- [ ] Add an appropriate identifier strategy.
- [ ] Test the repository with two different entity types.

**Deliverable:** A reusable generic collection component.

### Day 17 — Exceptions and validation
- [ ] Build a user-registration validator.
- [ ] Distinguish invalid user input from unexpected system failures.
- [ ] Choose suitable validation results or exceptions.
- [ ] Test missing fields and invalid values.

**Deliverable:** A validation component with predictable failure behavior.

### Day 18 — LINQ and data transformation
- [ ] Analyze a collection of orders using LINQ.
- [ ] Filter, sort, group, and aggregate the data.
- [ ] Calculate sales totals by category.
- [ ] Compare the readability of LINQ and loop-based solutions.

**Deliverable:** An order-reporting utility.

### Day 19 — Delegates and events
- [ ] Build an inventory notification example.
- [ ] Raise an event when stock falls below a threshold.
- [ ] Separate the inventory model from notification behavior.
- [ ] Test that the event occurs under the correct conditions.

**Deliverable:** An event-driven inventory exercise.

### Day 20 — Files and JSON
- [ ] Save a collection of expenses to JSON.
- [ ] Load saved data when the application starts.
- [ ] Handle missing or malformed files safely.
- [ ] Test saving, loading, and recovery scenarios.

**Deliverable:** A persistent expense-tracking console app.

### Day 21 — Weekly assessment
- [ ] Solve a small inventory-management problem without copying a solution.
- [ ] Use classes, collections, validation, and LINQ where appropriate.
- [ ] Add tests for the core business rules.
- [ ] Refactor any class that has too many responsibilities.

**Deliverable:** A documented inventory application.

## Week 4 — Testing and maintainable design

### Day 22 — Unit testing with xUnit
- [ ] Create a separate test project.
- [ ] Write tests for `BankAccount` or `Product`.
- [ ] Practice Arrange–Act–Assert.
- [ ] Run tests from the terminal.

**Deliverable:** A repeatable automated test suite.

### Day 23 — Test-driven development
- [ ] Implement a discount-calculation requirement.
- [ ] Write a failing test first.
- [ ] Implement the smallest change that passes.
- [ ] Refactor while keeping tests green.

**Deliverable:** A documented red–green–refactor exercise.

### Day 24 — Dependency inversion
- [ ] Design an order service that requires a notification service.
- [ ] Introduce an abstraction for notifications.
- [ ] Inject the dependency rather than constructing it inside the order service.
- [ ] Test the service with a fake implementation.

**Deliverable:** A loosely coupled service.

### Day 25 — SOLID principles in practice
- [ ] Review one existing project from the previous weeks.
- [ ] Identify violations of single responsibility and dependency inversion.
- [ ] Refactor one concrete design problem.
- [ ] Explain the improvement and any trade-offs.

**Deliverable:** Before-and-after design documentation.

### Day 26 — Debugging and defensive programming
- [ ] Intentionally introduce three bugs into a small program.
- [ ] Reproduce and isolate each failure.
- [ ] Use breakpoints or logging to locate the cause.
- [ ] Record the root cause and fix for each bug.

**Deliverable:** A debugging journal.

### Day 27 — Algorithmic thinking
- [ ] Solve two array or string problems.
- [ ] Explain the algorithm before implementing it.
- [ ] Analyze time and space complexity at a basic level.
- [ ] Compare a straightforward solution with an improved one.

**Deliverable:** Two explained and tested algorithm solutions.

### Day 28 — Month-one practical project
- [ ] Build a library-management console application.
- [ ] Support books, members, borrowing, and returning.
- [ ] Enforce borrowing rules.
- [ ] Persist data or document a deliberate in-memory limitation.
- [ ] Add unit tests and usage instructions.

**Deliverable:** A complete object-oriented project.

### Day 29 — Refactor and review
- [ ] Review the library application's class responsibilities.
- [ ] Remove duplicated logic and unnecessary coupling.
- [ ] Improve naming and error handling.
- [ ] Run the full test suite.

**Deliverable:** A cleaner, tested application.

### Day 30 — Month-one assessment
- [ ] Solve an unfamiliar object-oriented problem from scratch.
- [ ] Write requirements, pseudocode, class responsibilities, and tests.
- [ ] Complete a retrospective on problem-solving difficulties.
- [ ] Publish a month-one summary on GitHub.

**Deliverable:** A month-one portfolio review and measurable baseline.

---

# MONTH 2 — Databases, ASP.NET Core and Web APIs

**Goal:** Build a maintainable backend application that stores data and exposes useful API endpoints.

## Week 5 — SQL and relational data

### Day 31 — Relational database fundamentals
- [ ] Install or access a SQL database.
- [ ] Design tables for customers, products, and orders.
- [ ] Identify primary keys, foreign keys, and relationships.
- [ ] Document your schema.

**Deliverable:** A relational database design.

### Day 32 — SQL CRUD operations
- [ ] Write `INSERT`, `SELECT`, `UPDATE`, and `DELETE` statements.
- [ ] Use appropriate filters and ordering.
- [ ] Test operations against sample data.
- [ ] Document the queries and results.

**Deliverable:** A SQL practice script.

### Day 33 — Joins and aggregation
- [ ] Query orders together with customer information.
- [ ] Use joins, grouping, and aggregate functions.
- [ ] Calculate totals by customer.
- [ ] Explain the difference between the query results.

**Deliverable:** A reporting query collection.

### Day 34 — Constraints and transactions
- [ ] Add constraints to protect data integrity.
- [ ] Design an order-creation transaction.
- [ ] Ensure related changes succeed or fail together.
- [ ] Test failure scenarios.

**Deliverable:** A transaction-based SQL exercise.

### Day 35 — Database design and normalization
- [ ] Review your schema for duplicated data.
- [ ] Normalize tables where appropriate.
- [ ] Document the purpose of each relationship.
- [ ] Create a revised schema if needed.

**Deliverable:** A documented database design.

### Day 36 — Query parameters and security
- [ ] Practice parameterized SQL queries.
- [ ] Understand SQL injection risks.
- [ ] Avoid concatenating untrusted input into SQL.
- [ ] Test with unusual user input.

**Deliverable:** A safer database-access exercise.

### Day 37 — Weekly database assessment
- [ ] Build a small sales database.
- [ ] Insert sample customers, products, and orders.
- [ ] Write five meaningful reporting queries.
- [ ] Verify the results independently.

**Deliverable:** A database project with sample reports.

## Week 6 — Entity Framework Core

### Day 38 — First EF Core project
- [ ] Add EF Core and a suitable database provider.
- [ ] Create entity classes and a `DbContext`.
- [ ] Configure the connection string.
- [ ] Run a basic database query.

**Deliverable:** A working EF Core project.

### Day 39 — Migrations
- [ ] Create an initial migration.
- [ ] Apply it to the database.
- [ ] Change an entity and generate another migration.
- [ ] Inspect the resulting schema changes.

**Deliverable:** A versioned database schema.

### Day 40 — CRUD with EF Core
- [ ] Implement create, read, update, and delete operations.
- [ ] Use asynchronous database methods.
- [ ] Handle missing records.
- [ ] Test each operation.

**Deliverable:** A working data-access component.

### Day 41 — Relationships and loading
- [ ] Model customers and orders.
- [ ] Configure their relationship.
- [ ] Practice eager and explicit loading.
- [ ] Inspect queries to avoid unnecessary database calls.

**Deliverable:** A relational EF Core model.

### Day 42 — LINQ queries with EF Core
- [ ] Filter and sort database records.
- [ ] Project results into smaller objects.
- [ ] Add pagination.
- [ ] Learn which parts of a query execute in the database.

**Deliverable:** A paginated data-query component.

### Day 43 — Repository and service boundaries
- [ ] Separate business rules from persistence concerns.
- [ ] Decide whether a repository abstraction adds value for your application.
- [ ] Inject dependencies through constructors.
- [ ] Test business logic independently where practical.

**Deliverable:** A maintainable application structure.

### Day 44 — Database assessment
- [ ] Build a small product and inventory data layer.
- [ ] Add migrations, relationships, and validation.
- [ ] Test important persistence operations.
- [ ] Document setup and database requirements.

**Deliverable:** A tested EF Core component.

## Week 7 — ASP.NET Core Web API

### Day 45 — Create your first API
- [ ] Create an ASP.NET Core Web API project.
- [ ] Explore the application entry point and dependency injection.
- [ ] Add a simple endpoint.
- [ ] Run the API and inspect its response.

**Deliverable:** A running API project.

### Day 46 — HTTP methods and status codes
- [ ] Implement GET, POST, PUT, and DELETE endpoints.
- [ ] Choose appropriate HTTP status codes.
- [ ] Test requests using Swagger UI or an HTTP client.
- [ ] Document the endpoint behavior.

**Deliverable:** An API endpoint collection.

### Day 47 — DTOs and request validation
- [ ] Create request and response DTOs.
- [ ] Avoid exposing database entities directly as API contracts.
- [ ] Validate required fields and invalid values.
- [ ] Return consistent validation responses.

**Deliverable:** A validated API request flow.

### Day 48 — Dependency injection and configuration
- [ ] Register application services in the DI container.
- [ ] Use configuration for environment-specific settings.
- [ ] Understand service lifetimes.
- [ ] Avoid hardcoded secrets.

**Deliverable:** A configurable API.

### Day 49 — EF Core integration
- [ ] Connect your API to the database.
- [ ] Implement product or task CRUD endpoints.
- [ ] Handle missing records and database errors appropriately.
- [ ] Test persistence through HTTP requests.

**Deliverable:** A database-backed API.

### Day 50 — Filtering, sorting, and pagination
- [ ] Add filtering to a collection endpoint.
- [ ] Support sorting and pagination.
- [ ] Validate pagination parameters.
- [ ] Test empty and large result sets.

**Deliverable:** A practical collection endpoint.

### Day 51 — API assessment
- [ ] Build a complete task-management API.
- [ ] Support CRUD operations and request validation.
- [ ] Connect it to a database.
- [ ] Document routes and example requests.

**Deliverable:** A documented task API.

## Week 8 — API quality and testing

### Day 52 — Middleware and request pipelines
- [ ] Explore how requests pass through middleware.
- [ ] Add centralized exception handling.
- [ ] Return consistent error responses.
- [ ] Test both successful and failed requests.

**Deliverable:** A predictable error-handling pipeline.

### Day 53 — Logging and observability
- [ ] Add structured logging for important operations.
- [ ] Record useful diagnostic information.
- [ ] Avoid logging passwords, tokens, or sensitive data.
- [ ] Reproduce an error and use logs to investigate it.

**Deliverable:** A diagnosable API.

### Day 54 — Async programming
- [ ] Review `async`, `await`, and `Task`.
- [ ] Use asynchronous database operations.
- [ ] Avoid blocking asynchronous code with `.Result` or `.Wait()`.
- [ ] Test cancellation and error propagation where appropriate.

**Deliverable:** An asynchronous API workflow.

### Day 55 — Unit tests for services
- [ ] Write tests for business rules.
- [ ] Substitute dependencies with fakes or mocks where useful.
- [ ] Test success and failure cases.
- [ ] Check that tests do not depend on execution order.

**Deliverable:** A service unit-test suite.

### Day 56 — Integration testing
- [ ] Create API integration tests.
- [ ] Test HTTP requests, responses, and validation.
- [ ] Use an isolated test database or supported test host.
- [ ] Verify that important endpoints work together.

**Deliverable:** A repeatable integration-test suite.

### Day 57 — API security fundamentals
- [ ] Review input validation and error handling.
- [ ] Check that sensitive configuration is not committed.
- [ ] Understand authentication versus authorization.
- [ ] Identify endpoints that should require access control.

**Deliverable:** An API security checklist.

### Day 58 — Refactoring and performance
- [ ] Review slow or unnecessarily complex queries.
- [ ] Inspect database query behavior.
- [ ] Avoid unnecessary data loading and oversized responses.
- [ ] Refactor without breaking tests.

**Deliverable:** A measured and improved API.

### Day 59 — Month-two project completion
- [ ] Complete the task-management API.
- [ ] Add persistence, validation, logging, and automated tests.
- [ ] Write installation and usage instructions.
- [ ] Verify a clean setup from your documented instructions.

**Deliverable:** A portfolio-ready backend project.

### Day 60 — Month-two assessment
- [ ] Build one small endpoint independently.
- [ ] Explain its request flow from HTTP to database and back.
- [ ] Review test coverage and known limitations.
- [ ] Publish a month-two retrospective.

**Deliverable:** A documented API assessment.

---

# MONTH 3 — Professional Engineering and Portfolio Delivery

**Goal:** Improve security, reliability, maintainability, and deployment skills through one complete application.

## Week 9 — Authentication and authorization

### Day 61 — Authentication fundamentals
- [ ] Study authentication, authorization, and identity.
- [ ] Decide how users will authenticate in your project.
- [ ] Document the trust boundaries of the application.
- [ ] Identify public and protected operations.

**Deliverable:** An authentication design.

### Day 62 — Implement an authentication flow
- [ ] Use ASP.NET Core Identity or a suitable established authentication provider.
- [ ] Configure user registration or sign-in.
- [ ] Follow secure credential-storage practices.
- [ ] Test valid and invalid sign-in attempts.

**Deliverable:** A working authentication flow.

### Day 63 — Authorization policies
- [ ] Protect selected endpoints.
- [ ] Configure roles or policies where appropriate.
- [ ] Ensure users cannot access unauthorized resources.
- [ ] Test anonymous, authorized, and unauthorized requests.

**Deliverable:** Tested authorization rules.

### Day 64 — Ownership and access control
- [ ] Associate records with their owners.
- [ ] Prevent users from accessing other users' records.
- [ ] Check ownership in the business logic or data-access flow.
- [ ] Test cross-user access attempts.

**Deliverable:** Resource-level authorization.

### Day 65 — Secrets and secure configuration
- [ ] Remove secrets from source code.
- [ ] Configure development secrets and deployment environment variables.
- [ ] Review HTTPS and production configuration.
- [ ] Document safe configuration practices.

**Deliverable:** A security-conscious configuration.

### Day 66 — Security testing
- [ ] Test authentication failures and forbidden operations.
- [ ] Review validation and error responses.
- [ ] Check for accidental information disclosure.
- [ ] Document security limitations and mitigations.

**Deliverable:** A security test report.

### Day 67 — Weekly security assessment
- [ ] Review all protected endpoints.
- [ ] Test authorization boundaries.
- [ ] Fix identified issues.
- [ ] Record remaining risks.

**Deliverable:** An updated access-control implementation.

## Week 10 — Architecture and maintainability

### Day 68 — Application layering
- [ ] Review API, business logic, and data-access responsibilities.
- [ ] Separate concerns where the complexity justifies it.
- [ ] Avoid creating unnecessary layers for their own sake.
- [ ] Document the application structure.

**Deliverable:** A clear application architecture.

### Day 69 — Domain modeling
- [ ] Refine the main business entities.
- [ ] Identify invariants and domain rules.
- [ ] Decide which operations belong to each entity or service.
- [ ] Test the most important business rules.

**Deliverable:** A stronger domain model.

### Day 70 — Design patterns in context
- [ ] Select a real problem involving object creation or interchangeable behavior.
- [ ] Evaluate a suitable pattern, such as Strategy or Factory.
- [ ] Implement it only if it improves the design.
- [ ] Explain why simpler alternatives were or were not suitable.

**Deliverable:** A documented design-pattern exercise.

### Day 71 — Background work
- [ ] Build a background task for a noncritical operation.
- [ ] Use a supported .NET background-service pattern.
- [ ] Handle cancellation and failures.
- [ ] Test its lifecycle and logging.

**Deliverable:** A background-processing component.

### Day 72 — Caching
- [ ] Identify a read-heavy operation that could benefit from caching.
- [ ] Implement a suitable cache strategy.
- [ ] Define expiration and invalidation behavior.
- [ ] Verify correctness when cached data changes.

**Deliverable:** A measured caching improvement.

### Day 73 — API versioning and compatibility
- [ ] Study API contract compatibility.
- [ ] Design a nonbreaking response change.
- [ ] Decide when explicit API versioning is justified.
- [ ] Document your compatibility policy.

**Deliverable:** An API evolution exercise.

### Day 74 — Architecture review
- [ ] Review dependencies and responsibilities.
- [ ] Remove unnecessary abstractions.
- [ ] Check error handling and testability.
- [ ] Create an architecture diagram.

**Deliverable:** An architecture review report.

## Week 11 — Deployment and automation

### Day 75 — Production configuration
- [ ] Separate development and production settings.
- [ ] Configure logging and database connections.
- [ ] Review health and readiness requirements.
- [ ] Verify that secrets are supplied securely.

**Deliverable:** Production configuration documentation.

### Day 76 — Docker fundamentals
- [ ] Write a Dockerfile for the application.
- [ ] Build an image.
- [ ] Run the container locally.
- [ ] Verify the API is reachable.

**Deliverable:** A containerized application.

### Day 77 — Database deployment
- [ ] Configure a suitable database for the target environment.
- [ ] Apply schema migrations safely.
- [ ] Configure persistence and connection settings.
- [ ] Test the application against the deployed database.

**Deliverable:** A reproducible deployment configuration.

### Day 78 — CI with GitHub Actions
- [ ] Create a GitHub Actions workflow.
- [ ] Restore dependencies and build the project.
- [ ] Run automated tests on pushes and pull requests.
- [ ] Fix any failures.

**Deliverable:** Automated build and test checks.

### Day 79 — Code quality
- [ ] Enable or review appropriate .NET analyzers.
- [ ] Fix meaningful warnings.
- [ ] Format the code consistently.
- [ ] Document quality checks used in the project.

**Deliverable:** A cleaner, consistently formatted codebase.

### Day 80 — Performance and reliability
- [ ] Identify a potential bottleneck.
- [ ] Measure before optimizing.
- [ ] Test error handling and recovery.
- [ ] Document the results instead of making unsupported performance claims.

**Deliverable:** A performance and reliability report.

### Day 81 — Deployment practice
- [ ] Choose a suitable hosting platform.
- [ ] Deploy the application and configure required environment variables.
- [ ] Verify the public API and database connection.
- [ ] Document how to reproduce or troubleshoot the deployment.

**Deliverable:** A deployed application or a reproducible deployment package.

## Week 12 — Capstone project

### Day 82 — Define the capstone
- [ ] Choose a problem worth solving, such as personal finance tracking, inventory management, or task management.
- [ ] Identify users and their needs.
- [ ] Define a small set of essential features.
- [ ] Write acceptance criteria and a list of exclusions.

**Deliverable:** A clear project specification.

### Day 83 — Design the solution
- [ ] Identify entities, responsibilities, and relationships.
- [ ] Design the database schema and API contracts.
- [ ] Identify security requirements.
- [ ] Break the project into small, testable tasks.

**Deliverable:** A design and implementation plan.

### Day 84 — Implement the core domain
- [ ] Implement the main entities and business rules.
- [ ] Validate important state changes.
- [ ] Write unit tests for the domain.
- [ ] Commit the first functional milestone.

**Deliverable:** A tested domain layer.

### Day 85 — Implement persistence and APIs
- [ ] Add EF Core persistence and migrations.
- [ ] Implement essential endpoints.
- [ ] Add request validation and error handling.
- [ ] Test database-backed operations.

**Deliverable:** A functional backend.

### Day 86 — Add security and integration tests
- [ ] Configure the required authentication and authorization.
- [ ] Add integration tests for essential user flows.
- [ ] Test invalid input and unauthorized access.
- [ ] Fix high-priority defects.

**Deliverable:** A more secure, tested application.

### Day 87 — Prepare the release
- [ ] Add logging and production configuration.
- [ ] Create a Docker image or deployment configuration.
- [ ] Verify the build and test workflow.
- [ ] Test the release candidate.

**Deliverable:** A release candidate.

### Day 88 — Documentation and deployment
- [ ] Write the project README.
- [ ] Document setup, configuration, endpoints, and tests.
- [ ] Add an architecture diagram and example requests.
- [ ] Deploy the application or document reproducible deployment steps.

**Deliverable:** A usable project with professional documentation.

### Day 89 — Final quality review
- [ ] Clone the repository into a clean folder.
- [ ] Follow your own setup instructions from scratch.
- [ ] Run the build and tests.
- [ ] Fix missing dependencies, broken instructions, or exposed secrets.

**Deliverable:** A verified, reproducible project.

### Day 90 — Portfolio release and retrospective
- [ ] Tag a release, such as `v1.0.0`.
- [ ] Review the 90-day Git history.
- [ ] Summarize completed features, test results, and known limitations.
- [ ] Identify your three biggest remaining skill gaps.
- [ ] Plan the next 30 days based on those gaps.

**Deliverable:** A public portfolio project and a concrete next-step plan.

---

# Daily documentation template

Create a Markdown file for each learning session using this structure.

## Day [number] — [topic]

### 1. Objective
What problem or concept am I working on?

### 2. Problem statement
What are the inputs, outputs, constraints, and expected behavior?

### 3. My approach
Describe the algorithm, class responsibilities, and design choices before coding.

### 4. Implementation
Link to the relevant source files and explain the important decisions.

### 5. Testing
List normal cases, boundary cases, and failure cases.

### 6. What I learned
Explain the concepts in your own words.

### 7. Difficulties and solutions
What did I misunderstand? How did I investigate and fix it?

### 8. Improvement
What would I change if I solved this problem again?

### 9. Daily checklist
- [ ] Solved the problem independently.
- [ ] Ran the program successfully.
- [ ] Tested important cases.
- [ ] Updated documentation.
- [ ] Committed my work.

### 10. Tomorrow's target
State one specific, achievable objective.

---

# Recommended repository structure

```text
dotnet-90-day-journey/
├── README.md
├── docs/
│   ├── daily/
│   ├── weekly-reviews/
│   ├── architecture/
│   └── decisions/
├── src/
│   ├── ProblemSolvingLab/
│   ├── LibraryManagement/
│   └── Capstone/
├── tests/
│   ├── ProblemSolvingLab.Tests/
│   └── Capstone.Tests/
└── .github/
    └── workflows/
        └── dotnet.yml
```

Adjust the structure as the projects grow. Small exercises can have their own folders, while the capstone should have its own clear source and test projects.

# Git workflow

Make small, meaningful commits throughout the day rather than saving all your progress in one large commit.

Examples:

- `feat: implement bank account withdrawal rules`
- `test: add boundary tests for discount calculator`
- `refactor: separate order calculation responsibilities`
- `docs: record week 2 design lessons`
- `fix: prevent duplicate course enrollment`

Use branches and pull requests when useful, even for solo projects, to practice a professional workflow.

# Definition of done

A day is complete when you can:

1. Explain the problem in your own words.
2. Describe your approach before reading a solution.
3. Produce a working implementation.
4. Test important normal and edge cases.
5. Explain why you organized the code as you did.
6. Document what you learned and commit the result.

**The objective is not 90 green boxes at any cost. The objective is 90 days of increasingly independent engineering practice.**