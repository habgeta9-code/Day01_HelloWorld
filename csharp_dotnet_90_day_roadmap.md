# 90-Day C#/.NET Practice Roadmap

> **Designed for a programmer who already understands variables, functions, classes, and basic control flow.** This plan prioritizes implementation, debugging, tests, documentation, and shipping a complete project—not beginner lectures.

## Goal by Day 90

Build and publish a professional **Personal Learning Tracker API** using C#, .NET, ASP.NET Core, Entity Framework Core, a relational database, automated tests, GitHub Actions, and clear documentation. The API will track learning goals and daily study sessions, so the final project supports the learning-journal workflow itself.

This route emphasizes backend development because it gives you one coherent project to carry from console practice to a real API. Microsoft’s official .NET documentation provides tutorials for apps, Web APIs, data access, authentication, and testing; use those docs as references while writing your own implementation. See the [official .NET tutorials](https://learn.microsoft.com/en-us/dotnet/core/tutorials/), [ASP.NET Core Web API tutorial](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-web-api), [EF Core getting started](https://learn.microsoft.com/en-us/ef/core/get-started/overview/install), and [testing in .NET](https://learn.microsoft.com/en-us/dotnet/core/testing/).

## Time commitment and daily rules

- **Target:** 90 days, 6 active learning days plus one lighter review day per week. If a day takes longer, continue the next day rather than skipping tests or documentation.
- **Daily target:** approximately 90–120 minutes: 10 minutes retrieval practice, 20 minutes documentation/reference reading, 45–60 minutes coding, 10–15 minutes testing/debugging, and 10–15 minutes notes and Git.
- **Rule 1 — Build, don’t just watch:** read enough to understand the next task, close the tutorial, and implement it yourself.
- **Rule 2 — Write something every day:** record the idea in your own words, why it matters, what you tried, the result, one problem/fix, and the next question.
- **Rule 3 — Commit real progress:** commit a coherent working change when possible. Do not fake activity or commit secrets, `bin/`, `obj/`, local database files containing private data, or credentials.
- **Rule 4 — Test behavior:** for features, include a success case and a failure/edge case. Run `dotnet build` and relevant `dotnet test` before finishing.
- **Rule 5 — Keep scope small:** the target is a reliable, understandable API, not a microservices architecture.

## Technology baseline

- Use the latest patched **.NET 10 LTS SDK** available to you as the default target; Microsoft lists .NET 10 as active LTS through November 14, 2028 as of October 2026. Check the official [support policy](https://dotnet.microsoft.com/en-us/platform/support/policy) before starting, especially if your machine already has another SDK.
- Editor: VS Code with the C# Dev Kit or another editor you already use.
- Version control: Git and a GitHub repository.
- Database: PostgreSQL is preferred for realistic backend practice; SQLite is an acceptable fallback if local database setup becomes a blocker. Keep the database provider choice consistent once migrations are created.
- Testing: choose one mainstream .NET test framework (for example, xUnit or MSTest) and use it consistently.
- Security: use standard ASP.NET Core authentication guidance or a trusted identity provider; do not invent your own password hashing or token system for production.

## Repository layout

```text
dotnet-90-day-lab/
├── README.md
├── docs/
│   ├── roadmap.md
│   ├── daily/                  # day-001.md ... day-090.md
│   └── weekly/                 # weekly reviews and retrospectives
├── src/
│   ├── ConsolePractice/        # early C#/.NET experiments
│   └── LearningTracker.Api/    # capstone Web API
├── tests/
│   ├── LearningTracker.UnitTests/
│   └── LearningTracker.IntegrationTests/
├── .editorconfig
└── .gitignore
```

You may introduce separate Domain/Application/Infrastructure projects later only if the project has a clear reason for them. Avoid adding architecture layers just to make the folder tree look professional.

## The daily Definition of Done

Use this checklist every day, in addition to the specific task listed below:

- [ ] Implemented the day’s task without blindly copying a solution.
- [ ] Built and/or ran the code; tested a normal path and at least one relevant edge case.
- [ ] Wrote `docs/daily/day-NNN.md` with: goal, key concept in my words, what I built, commands/run output, problem and fix, test results, and what comes next.
- [ ] Updated the main README or weekly progress summary when a milestone changed.
- [ ] Committed meaningful changes to Git with a specific message, e.g. `day-012: persist sessions as JSON`.
- [ ] If blocked, wrote down the exact error, what I tried, and the next experiment rather than silently abandoning the task.

Suggested daily note template: copy `templates/daily-note-template.md` below into `docs/daily/day-NNN.md` (create the `templates/` folder if you want to store it separately).

```markdown
# Day NNN — Title
- Date:
- Time spent:
- Goal:
## What I learned (in my own words)
## What I built
## Commands and example output
## Tests and results
## Problem encountered and how I investigated it
## What I would improve
## Next step
## Commit
```

## Phase map

| Days | Focus | Evidence at the end |
|---|---|---|
| 1–14 | C# fluency and robust CLI programs | JSON-backed Learning Tracker CLI |
| 15–28 | Testing, design, configuration, logging, DI, HTTP | Tested, maintainable CLI v1.0 |
| 29–42 | ASP.NET Core Web API and EF Core | Database-backed API with CRUD |
| 43–56 | Service structure, API features, tests | Filtered/paginated API with integration tests |
| 57–70 | Security and operations | Authorization, health, logging, operational review |
| 71–84 | Release workflow, CI/container/deployment, capstone | Release candidate and professional docs |
| 85–90 | Audit, polish, final release and retrospective | Reproducible portfolio project v1.0 |

---

## 90-day daily checklist

### Week 1 — Tooling, C# fluency, and deliberate practice

#### Day 01 — Set up the learning repository
- [ ] **Build/practice:** Verify the .NET SDK with `dotnet --info`; install/update Git and the C# VS Code extension; create the repository, a solution, a console project, `.gitignore`, `README.md`, and `docs/daily/`.
- [ ] **Evidence:** A clean repository and a console app that builds.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-001:`.

#### Day 02 — Use the CLI and debugger
- [ ] **Build/practice:** Run `dotnet build`, `dotnet run`, and `dotnet clean`; add breakpoints, inspect locals, step into/over, and reproduce one bug before fixing it.
- [ ] **Evidence:** A short debugging note with the original bug and fix.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-002:`.

#### Day 03 — Practice strings, parsing, and formatting
- [ ] **Build/practice:** Build a console calculator or unit converter. Handle invalid input with `TryParse`; use interpolation and format numeric output clearly.
- [ ] **Evidence:** An input-driven program that handles invalid input without crashing.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-003:`.

#### Day 04 — Work with collections
- [ ] **Build/practice:** Use arrays, `List<T>`, `Dictionary<TKey,TValue>`, and `HashSet<T>` to manage a small set of study activities. Add, find, update, and remove items.
- [ ] **Evidence:** A collection exercise with examples of when each collection fits.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-004:`.

#### Day 05 — Use LINQ in real code
- [ ] **Build/practice:** Practice `Where`, `Select`, `OrderBy`, `Any`, `FirstOrDefault`, `Count`, and `Sum` on sample study records. Compare a loop with a LINQ query.
- [ ] **Evidence:** A report that filters and summarizes the sample data.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-005:`.

#### Day 06 — Practice records, enums, and pattern matching
- [ ] **Build/practice:** Model a learning session using a `record` and a status `enum`; use a `switch` expression or pattern matching to format each status.
- [ ] **Evidence:** A small model with readable status-handling code.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-006:`.

#### Day 07 — Weekly review and timed challenge
- [ ] **Build/practice:** Without copying a tutorial, build a console program that stores sessions in memory, validates input, and prints a summary. Review all Week 1 notes.
- [ ] **Evidence:** A working mini-project and a list of three strengths and three gaps.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-007:`.

### Week 2 — Stronger C# and robust program behavior

#### Day 08 — Nullable reference types and guard clauses
- [ ] **Build/practice:** Enable nullable reference types; handle missing values intentionally. Add guard clauses and avoid using `!` just to silence warnings.
- [ ] **Evidence:** A null-safe version of an earlier exercise.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-008:`.

#### Day 09 — Exceptions and validation
- [ ] **Build/practice:** Distinguish expected invalid user input from exceptional failures. Use `try/catch` narrowly, and never swallow exceptions silently.
- [ ] **Evidence:** A validation/error-handling decision note with tested cases.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-009:`.

#### Day 10 — Generics and reusable code
- [ ] **Build/practice:** Create a small generic helper or generic collection-based component. Decide whether generics make the code clearer than a concrete implementation.
- [ ] **Evidence:** A reusable component with at least two type examples.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-010:`.

#### Day 11 — Interfaces and composition
- [ ] **Build/practice:** Model a study log service behind an interface. Inject its dependency through a constructor instead of constructing dependencies deep inside the class.
- [ ] **Evidence:** A class that can use either a real or fake implementation.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-011:`.

#### Day 12 — Asynchronous programming
- [ ] **Build/practice:** Use `async`/`await`, `Task` and `Task<T>` in a simple asynchronous workflow. Pass a `CancellationToken` to a cancellable operation.
- [ ] **Evidence:** A program that awaits work correctly and can cancel it.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-012:`.

#### Day 13 — Files, paths, and JSON
- [ ] **Build/practice:** Persist learning-session records to a JSON file. Use `System.IO` and `System.Text.Json`; handle a missing file and invalid JSON deliberately.
- [ ] **Evidence:** Data survives restarting the program; document the JSON shape.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-013:`.

#### Day 14 — Milestone 1: Learning Tracker CLI
- [ ] **Build/practice:** Build a command-line app that can add, list, complete, and delete learning goals or sessions, and stores them in JSON. Refactor duplicated logic.
- [ ] **Evidence:** A usable CLI project with a README and sample run.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-014:`.

### Week 3 — Testing, design, and maintainability

#### Day 15 — Create a test project
- [ ] **Build/practice:** Add a unit-test project to the solution using a supported framework such as xUnit or MSTest. Run tests with `dotnet test`.
- [ ] **Evidence:** A test project that runs from the terminal.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-015:`.

#### Day 16 — Test behavior and edge cases
- [ ] **Build/practice:** Write tests for successful inputs, invalid inputs, empty collections, missing records, and boundary values. Use Arrange–Act–Assert.
- [ ] **Evidence:** At least 8 meaningful unit tests.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-016:`.

#### Day 17 — Practice test-driven development
- [ ] **Build/practice:** Choose a business rule (for example, a study session must have a positive duration). Write a failing test, implement the rule, then refactor.
- [ ] **Evidence:** A commit history showing test-first development.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-017:`.

#### Day 18 — Use test doubles effectively
- [ ] **Build/practice:** Replace a dependency such as a file store or clock with a fake implementation in tests. Avoid mocking internal details unnecessarily.
- [ ] **Evidence:** Tests run without depending on your real JSON file.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-018:`.

#### Day 19 — Refactor around responsibilities
- [ ] **Build/practice:** Identify a class doing too many things. Separate validation, business rules, persistence, and presentation only where the separation makes the code easier to change.
- [ ] **Evidence:** A before/after note describing why the design improved.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-019:`.

#### Day 20 — Add code-quality conventions
- [ ] **Build/practice:** Add an `.editorconfig`; standardize naming and formatting; enable useful compiler warnings; add XML comments only to public APIs where they add value.
- [ ] **Evidence:** Consistent formatting and a clean build.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-020:`.

#### Day 21 — Milestone 2: tested CLI
- [ ] **Build/practice:** Run the app from a clean checkout; test normal and failure paths; remove dead code and update the README with commands and limitations.
- [ ] **Evidence:** Version 0.2 of the CLI with repeatable tests.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-021:`.

### Week 4 — .NET application infrastructure

#### Day 22 — Make HTTP requests
- [ ] **Build/practice:** Use `HttpClient` to call a public test API or a local endpoint. Read status codes, deserialize JSON, and handle timeouts and network failures.
- [ ] **Evidence:** A small HTTP client with documented failure behavior.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-022:`.

#### Day 23 — Use configuration
- [ ] **Build/practice:** Move suitable settings into `appsettings.json` and environment variables. Keep secrets and credentials out of source control.
- [ ] **Evidence:** A configuration example that works in development without committed secrets.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-023:`.

#### Day 24 — Add logging
- [ ] **Build/practice:** Use `ILogger<T>` and meaningful log levels. Log state transitions and failures without logging passwords, tokens, or sensitive data.
- [ ] **Evidence:** Useful logs that help diagnose one deliberately reproduced issue.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-024:`.

#### Day 25 — Practice dependency injection lifetimes
- [ ] **Build/practice:** Register services with the built-in DI container; experiment with singleton, scoped, and transient lifetimes in a small example.
- [ ] **Evidence:** A note explaining which lifetime fits each service and why.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-025:`.

#### Day 26 — Use the options pattern
- [ ] **Build/practice:** Bind a configuration section to a typed options class and validate required settings at startup where practical.
- [ ] **Evidence:** A typed settings class and a tested invalid-configuration case.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-026:`.

#### Day 27 — Separate environment-specific behavior
- [ ] **Build/practice:** Use development configuration and environment variables; verify that changing configuration does not require editing application code.
- [ ] **Evidence:** A program that behaves differently via configuration, not code edits.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-027:`.

#### Day 28 — Milestone 3: maintainable CLI
- [ ] **Build/practice:** Integrate configuration, logging, DI, JSON persistence, and tests into the CLI. Keep it small; do not add abstractions without a reason.
- [ ] **Evidence:** A polished CLI v1.0, with usage instructions and known limitations.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-028:`.

### Week 5 — HTTP and ASP.NET Core Web API

#### Day 29 — Design resources and endpoints
- [ ] **Build/practice:** Sketch REST resources for a Personal Learning Tracker API: learning goals and daily study sessions. Define endpoints and expected status codes before coding.
- [ ] **Evidence:** An endpoint table and sample JSON request/response bodies.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-029:`.

#### Day 30 — Create the Web API project
- [ ] **Build/practice:** Create an ASP.NET Core controller-based Web API in the solution. Run it, inspect the template, and understand `Program.cs`, middleware, routing, and OpenAPI output.
- [ ] **Evidence:** The API launches locally and its generated docs are accessible.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-030:`.

#### Day 31 — Build read endpoints
- [ ] **Build/practice:** Implement `GET` endpoints using in-memory data first. Return appropriate results for collection and single-item requests, including not found.
- [ ] **Evidence:** Working read endpoints tested with `.http` requests or curl.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-031:`.

#### Day 32 — Build create endpoints
- [ ] **Build/practice:** Add a request DTO and a `POST` action. Validate incoming data and return `201 Created` with a location when creation succeeds.
- [ ] **Evidence:** A create request and tests for valid and invalid input.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-032:`.

#### Day 33 — Implement update and delete
- [ ] **Build/practice:** Add update and delete behavior. Define missing-ID behavior and use HTTP status codes consistently.
- [ ] **Evidence:** CRUD behavior demonstrated through repeatable requests.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-033:`.

#### Day 34 — Handle errors consistently
- [ ] **Build/practice:** Use a consistent error response such as Problem Details and a global exception handler where suitable. Do not return stack traces to clients.
- [ ] **Evidence:** Documented error shape and tested 400/404/500 behavior.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-034:`.

#### Day 35 — Milestone 4: in-memory API
- [ ] **Build/practice:** Review naming, routes, response codes, DTOs, and endpoint behavior. Update the README with how to start and test the API.
- [ ] **Evidence:** An API prototype that works before adding a database.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-035:`.

### Week 6 — EF Core and relational persistence

#### Day 36 — Design the data model
- [ ] **Build/practice:** Design `LearningGoal` and `StudySession` entities and their relationship. Define required fields, length limits, statuses, and date/time meaning.
- [ ] **Evidence:** A simple ER diagram or written relationship description.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-036:`.

#### Day 37 — Add Entity Framework Core
- [ ] **Build/practice:** Choose a database. Prefer PostgreSQL if you can run it locally; SQLite is a practical fallback. Add the matching EF Core provider and register `DbContext`.
- [ ] **Evidence:** The API connects to a local development database.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-037:`.

#### Day 38 — Create and apply migrations
- [ ] **Build/practice:** Install/configure EF Core tooling, create the initial migration, apply it, and inspect the resulting schema. Keep migrations in source control.
- [ ] **Evidence:** A reproducible database schema created from migrations.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-038:`.

#### Day 39 — Query data safely and efficiently
- [ ] **Build/practice:** Implement async list/detail queries. Use `AsNoTracking` for read-only queries where appropriate and project to DTOs rather than exposing EF entities.
- [ ] **Evidence:** Read endpoints now return persisted data.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-039:`.

#### Day 40 — Persist create, update, and delete
- [ ] **Build/practice:** Move CRUD operations to the database. Handle missing records and save changes asynchronously.
- [ ] **Evidence:** CRUD works after restarting the API.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-040:`.

#### Day 41 — Model relationships and constraints
- [ ] **Build/practice:** Add the relationship between learning goals and sessions. Add appropriate required fields, maximum lengths, foreign keys, and indexes where justified.
- [ ] **Evidence:** Relationship and constraint behavior verified.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-041:`.

#### Day 42 — Milestone 5: database-backed API
- [ ] **Build/practice:** Rebuild the database from migrations, test CRUD end to end, and document database setup and reset steps.
- [ ] **Evidence:** The API runs against a real relational database.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-042:`.

### Week 7 — Application structure and useful API features

#### Day 43 — Extract application services
- [ ] **Build/practice:** Move business operations out of controllers into focused services where that separation improves testability. Keep controllers thin.
- [ ] **Evidence:** Controllers mostly handle HTTP concerns; services handle use cases.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-043:`.

#### Day 44 — Use DTOs and mapping deliberately
- [ ] **Build/practice:** Separate request DTOs, response DTOs, and database entities. Map them explicitly and prevent clients from setting server-managed fields.
- [ ] **Evidence:** Create/update requests cannot over-post protected fields.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-044:`.

#### Day 45 — Add filtering and sorting
- [ ] **Build/practice:** Allow safe filters such as status or date range and a small whitelist of sort fields. Validate query parameters.
- [ ] **Evidence:** Documented filters with tests for supported and invalid values.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-045:`.

#### Day 46 — Add pagination
- [ ] **Build/practice:** Implement `page`/`pageSize` or cursor-style pagination, with sensible limits and stable ordering. Return metadata when useful.
- [ ] **Evidence:** Large collections return predictable pages rather than everything at once.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-046:`.

#### Day 47 — Validate business rules
- [ ] **Build/practice:** Add rules such as end time after start time, positive duration, valid status transitions, and title length. Keep rules out of HTTP-only code when reusable.
- [ ] **Evidence:** Unit tests cover both valid and invalid domain inputs.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-047:`.

#### Day 48 — Support cancellation and async database calls
- [ ] **Build/practice:** Pass `CancellationToken` through controller/service/database calls. Remove unnecessary `.Result`, `.Wait()`, and `async void` patterns.
- [ ] **Evidence:** Async flow is consistent and cancellable.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-048:`.

#### Day 49 — Milestone 6: API feature review
- [ ] **Build/practice:** Run all tests; manually test filtering, sorting, pagination, and validation. Review the shape of the service layer and simplify overengineering.
- [ ] **Evidence:** A maintainable API feature set and updated API examples.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-049:`.

### Week 8 — Automated testing from unit to integration

#### Day 50 — Test service-level business rules
- [ ] **Build/practice:** Test service behavior with in-memory fakes or test doubles where suitable. Include successful, missing-data, and invalid-input cases.
- [ ] **Evidence:** Focused unit tests for important rules.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-050:`.

#### Day 51 — Set up API integration tests
- [ ] **Build/practice:** Use `WebApplicationFactory` or the supported ASP.NET Core integration-test approach. Make test configuration separate from development configuration.
- [ ] **Evidence:** Integration tests can start the API test host automatically.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-051:`.

#### Day 52 — Test HTTP contracts
- [ ] **Build/practice:** Test endpoint routes, status codes, headers, response bodies, and validation failures. Assert observable behavior rather than private implementation details.
- [ ] **Evidence:** Tests cover the main endpoint contracts.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-052:`.

#### Day 53 — Isolate database tests
- [ ] **Build/practice:** Choose a reliable test database strategy. Avoid assuming EF Core's in-memory provider behaves exactly like a relational database; test migrations/constraints with a relational provider where possible.
- [ ] **Evidence:** Database-backed tests are repeatable and isolated.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-053:`.

#### Day 54 — Test global failures and edge cases
- [ ] **Build/practice:** Test not-found responses, conflicting or invalid data, unexpected errors, and empty/paginated results.
- [ ] **Evidence:** A test matrix of expected API outcomes.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-054:`.

#### Day 55 — Measure and improve test coverage
- [ ] **Build/practice:** Run coverage tooling if available. Find untested critical behavior; focus on meaningful scenarios rather than chasing a percentage.
- [ ] **Evidence:** A short coverage note and a list of remaining gaps.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-055:`.

#### Day 56 — Milestone 7: confidence check
- [ ] **Build/practice:** Run `dotnet test` from the repository root and fix flaky tests. Record the exact command and expected result in documentation.
- [ ] **Evidence:** A repeatable test suite ready for CI.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-056:`.

### Week 9 — Authentication, authorization, and security

#### Day 57 — Understand the security model
- [ ] **Build/practice:** Document assets, trust boundaries, and threats for the API. Distinguish authentication (who are you?) from authorization (what may you do?).
- [ ] **Evidence:** A small threat-model note with top risks and mitigations.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-057:`.

#### Day 58 — Choose a standard authentication approach
- [ ] **Build/practice:** Follow current ASP.NET Core guidance for bearer-token authentication or an identity provider. Avoid inventing a token scheme or storing plaintext passwords.
- [ ] **Evidence:** A documented setup decision and secure local configuration.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-058:`.

#### Day 59 — Protect private endpoints
- [ ] **Build/practice:** Require authenticated users for selected endpoints. Keep secrets in local user-secrets/environment variables and never commit tokens or signing keys.
- [ ] **Evidence:** Anonymous requests are denied where expected.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-059:`.

#### Day 60 — Enforce resource ownership
- [ ] **Build/practice:** Associate user-owned goals/sessions with the current user and ensure one user cannot read or modify another user's data.
- [ ] **Evidence:** Ownership rules and tests for cross-user access.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-060:`.

#### Day 61 — Add policy-based authorization
- [ ] **Build/practice:** Add one policy for a meaningful rule. Keep authorization checks explicit and central enough to audit.
- [ ] **Evidence:** A policy-protected endpoint with allowed/denied tests.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-061:`.

#### Day 62 — Harden inputs and transport
- [ ] **Build/practice:** Review HTTPS, CORS allowlists, request-size limits, rate limiting where suitable, dependency updates, and error details. Do not treat CORS as authentication.
- [ ] **Evidence:** A security checklist with fixes for the risks found.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-062:`.

#### Day 63 — Milestone 8: security review
- [ ] **Build/practice:** Test unauthenticated, authenticated-but-forbidden, and authorized requests. Review configuration and repository history for accidental secrets.
- [ ] **Evidence:** Security behavior is documented and verified.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-063:`.

### Week 10 — Observability, API quality, and resilience

#### Day 64 — Improve OpenAPI documentation
- [ ] **Build/practice:** Add useful summaries, response types, example requests, validation notes, and authentication descriptions. Ensure docs match actual API behavior.
- [ ] **Evidence:** A developer can use the API without reading source code.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-064:`.

#### Day 65 — Add health checks
- [ ] **Build/practice:** Add a health endpoint and, where appropriate, a database readiness check. Do not reveal sensitive configuration in health responses.
- [ ] **Evidence:** Health/readiness behavior is clear and testable.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-065:`.

#### Day 66 — Improve structured logging
- [ ] **Build/practice:** Log request failures and important business events with structured properties; avoid personally sensitive data and secrets.
- [ ] **Evidence:** Logs help diagnose an intentionally reproduced failure.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-066:`.

#### Day 67 — Review database performance
- [ ] **Build/practice:** Inspect generated SQL for key queries. Add indexes only where query patterns justify them; avoid loading related data unnecessarily.
- [ ] **Evidence:** One query improvement backed by an explanation or measurement.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-067:`.

#### Day 68 — Review outbound HTTP resilience
- [ ] **Build/practice:** If the app calls external services, configure timeouts and an appropriate resilience strategy. Do not retry non-idempotent actions blindly.
- [ ] **Evidence:** A documented timeout/failure strategy.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-068:`.

#### Day 69 — Check cancellation and error boundaries
- [ ] **Build/practice:** Ensure cancellation is propagated and errors are translated consistently. Distinguish client errors from unexpected server faults.
- [ ] **Evidence:** A consistent exception and cancellation policy.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-069:`.

#### Day 70 — Milestone 9: operational review
- [ ] **Build/practice:** Run a small end-to-end scenario while watching logs, health checks, and database behavior. Fix the most important operational gap.
- [ ] **Evidence:** An operations note describing how to diagnose common failures.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-070:`.

### Week 11 — GitHub workflow, containers, and deployment

#### Day 71 — Create a clean build and publish
- [ ] **Build/practice:** Run Release builds and `dotnet publish`. Inspect outputs and verify the published app starts with configuration supplied externally.
- [ ] **Evidence:** A repeatable publish command and successful smoke test.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-071:`.

#### Day 72 — Containerize the API
- [ ] **Build/practice:** Write a multi-stage Dockerfile based on official .NET images, use a non-root runtime where appropriate, and keep secrets out of image layers.
- [ ] **Evidence:** The API builds and runs in a container.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-072:`.

#### Day 73 — Run the database and API locally
- [ ] **Build/practice:** Use Docker Compose if available to coordinate the API and database. Configure service names, persistent data as needed, and environment variables.
- [ ] **Evidence:** A documented one-command local environment.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-073:`.

#### Day 74 — Automate CI with GitHub Actions
- [ ] **Build/practice:** Add a workflow that restores, builds, and runs tests on pushes and pull requests. Use supported, maintained action versions.
- [ ] **Evidence:** A green CI run visible on GitHub.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-074:`.

#### Day 75 — Add branch and review discipline
- [ ] **Build/practice:** Create a feature branch, open a pull request against your own repository, review the diff, and merge only after checks pass.
- [ ] **Evidence:** One complete practice PR and a clean main branch.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-075:`.

#### Day 76 — Prepare a release
- [ ] **Build/practice:** Use a version tag or GitHub Release; write release notes, list breaking changes, and record configuration/database requirements.
- [ ] **Evidence:** A versioned release candidate.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-076:`.

#### Day 77 — Deploy if a suitable free/starter environment is available
- [ ] **Build/practice:** Deploy the API and database or follow a documented local deployment path if hosting requires payment or account setup. Verify health, logs, and database connectivity.
- [ ] **Evidence:** A deployment URL or a complete reproducible deployment guide.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-077:`.

### Week 12 — Capstone completion and portfolio polish

#### Day 78 — Freeze capstone scope
- [ ] **Build/practice:** Write user stories and acceptance criteria for the Personal Learning Tracker: goals, sessions, status, summaries, filters, and user access. Create GitHub Issues for remaining work.
- [ ] **Evidence:** A small, prioritized backlog—no feature creep.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-078:`.

#### Day 79 — Finish end-to-end goal workflows
- [ ] **Build/practice:** Complete create, view, edit, complete/archive, and delete workflows; check missing IDs and invalid values.
- [ ] **Evidence:** All core goal workflows pass manual and automated tests.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-079:`.

#### Day 80 — Finish study-session workflows
- [ ] **Build/practice:** Complete create/list/update/delete session workflows and summaries of time studied by date range or goal.
- [ ] **Evidence:** A user can record sessions and see useful progress summaries.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-080:`.

#### Day 81 — Polish API contract and errors
- [ ] **Build/practice:** Review pagination limits, validation responses, status codes, date/time handling, and DTO boundaries. Remove inconsistent endpoint behavior.
- [ ] **Evidence:** Consistent, documented API responses.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-081:`.

#### Day 82 — Finish critical tests
- [ ] **Build/practice:** Add or refine unit and integration tests for the highest-risk behaviors: ownership, validation, persistence, and error handling.
- [ ] **Evidence:** All critical paths have automated tests and CI passes.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-082:`.

#### Day 83 — Write professional documentation
- [ ] **Build/practice:** Update README with purpose, feature list, architecture, prerequisites, setup, configuration, migrations, running tests, API examples, screenshots/diagrams if useful, and known limitations.
- [ ] **Evidence:** A new developer can clone and run the project using only the README.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-083:`.

#### Day 84 — Release v1.0 and retrospect
- [ ] **Build/practice:** Clone into a clean directory and follow your own README. Fix setup gaps, tag a release, review all 90 daily notes, and write the next 90-day plan based on evidence.
- [ ] **Evidence:** A tagged, reproducible portfolio project and a written retrospective.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-084:`.

### Final stretch — polish and release

#### Day 85 — Security and configuration audit
- [ ] **Build/practice:** Audit secrets, authentication, authorization, environment settings, CORS, error responses, and dependency versions. Remove any secrets from tracked files and rotate exposed credentials if any were committed.
- [ ] **Evidence:** A completed security checklist and documented fixes.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-085:`.

#### Day 86 — Performance and database audit
- [ ] **Build/practice:** Recheck slow queries, pagination limits, indexes, async calls, and unnecessary allocations. Measure before optimizing; write down the baseline and result.
- [ ] **Evidence:** One measured improvement or a clear record that no optimization was justified.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-086:`.

#### Day 87 — Code readability pass
- [ ] **Build/practice:** Review naming, methods, dependency boundaries, duplicated code, null handling, and exception flow. Use formatting and analyzers; don't refactor solely to follow a pattern.
- [ ] **Evidence:** A clean diff focused on maintainability.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-087:`.

#### Day 88 — Fresh-machine setup test
- [ ] **Build/practice:** Pretend you are a new contributor: start from a clean clone, follow the README, set environment variables, apply migrations, run tests, and start the API.
- [ ] **Evidence:** A first-time setup succeeds without undocumented steps.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-088:`.

#### Day 89 — Portfolio presentation
- [ ] **Build/practice:** Add a concise project summary, architecture sketch, sample requests/responses, test/CI status, screenshots only if useful, and a demo script. Link to selected daily notes.
- [ ] **Evidence:** A repository that clearly demonstrates your engineering process.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-089:`.

#### Day 90 — Final assessment and next plan
- [ ] **Build/practice:** Rate yourself 1–5 on C#, .NET CLI, API design, EF Core/SQL, testing, security, debugging, Git, and documentation. List the five biggest gaps and choose one specialization for the next quarter.
- [ ] **Evidence:** A retrospective and evidence-based next learning plan.
- [ ] **Document and commit:** complete the daily Definition of Done; use commit prefix `day-090:`.

## Weekly review — do this on Days 7, 14, 21, and every seventh day after that

- [ ] Build the whole solution and run all tests from the terminal.
- [ ] Review the week’s daily notes. Rewrite vague notes so they explain the why, not just the what.
- [ ] Identify one repeated mistake or knowledge gap and schedule a focused exercise for the next week.
- [ ] Check Git history: meaningful commit messages, no credentials, no generated build folders, no giant unrelated commits.
- [ ] Update the README progress table with completed days, current milestone, tests passing, and next milestone.
- [ ] Spend the review day strengthening or finishing work—not adding new scope to compensate for missed days.

## Suggested Git routine

```bash
git status
dotnet build
dotnet test
git add .
git commit -m "day-001: initialize learning repository"
git push
```

Run `dotnet test` once the test projects exist. If a day is only documentation or a focused experiment, run the relevant checks rather than forcing a meaningless build. Before pushing, inspect `git diff --staged` and confirm no secrets or local data are included.

## Milestone acceptance criteria

### Day 14 — CLI milestone
- [ ] Add, list, update/complete, and delete learning goals or sessions.
- [ ] Data persists between runs using JSON.
- [ ] Invalid input does not crash the app unexpectedly.
- [ ] README explains how to run it and gives a sample session.

### Day 35 — quality milestone
- [ ] Core rules have automated unit tests.
- [ ] Dependencies can be replaced with fakes in tests.
- [ ] Code builds cleanly and the project is understandable from its docs.

### Day 56 — API milestone
- [ ] API has documented CRUD endpoints and a relational database.
- [ ] Validation, error responses, filtering, and pagination behave predictably.
- [ ] Tests cover core business rules and API contracts.

### Day 70 — reliability milestone
- [ ] Authentication/authorization requirements are implemented appropriately for the project scope.
- [ ] Health checks, structured logging, and useful error handling are available.
- [ ] Tests and local setup are repeatable.

### Day 90 — portfolio milestone
- [ ] A fresh clone can be configured and run by following the README.
- [ ] CI builds and tests the project.
- [ ] The repository includes architecture/setup notes, API examples, test instructions, and a release tag.
- [ ] Daily documentation shows the progression from practice exercises to a shipped application.

## Official references

Use the official documentation as a reference, not as a substitute for implementation:

- [.NET tutorials](https://learn.microsoft.com/en-us/dotnet/core/tutorials/) — console apps, debugging, publishing, libraries, and tests.
- [C# language guide](https://learn.microsoft.com/en-us/dotnet/csharp/) — language features and idioms.
- [ASP.NET Core controller-based Web API tutorial](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-web-api) — routes, CRUD, DI, and response behavior.
- [Entity Framework Core installation/getting started](https://learn.microsoft.com/en-us/ef/core/get-started/overview/install) — packages, providers, and tooling.
- [Testing in .NET](https://learn.microsoft.com/en-us/dotnet/core/testing/) — unit, integration, and other test types.
- [.NET support policy](https://dotnet.microsoft.com/en-us/platform/support/policy) — confirm the supported SDK version and servicing status.

## Important scope note

This plan is ambitious but adjustable. If you fall behind, keep the daily documentation habit and prioritize a working, tested vertical slice over checking every box on the original date. Authentication and deployment can take longer depending on your environment. Do not publish credentials or real personal data. The goal is to demonstrate sound engineering habits and a project you can explain—not to collect technologies without understanding them.