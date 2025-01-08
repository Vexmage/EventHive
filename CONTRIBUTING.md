# Contribution Guidelines

Thank you for considering contributing to EventHive! By following these guidelines, you can help us maintain a collaborative, organized, and efficient project environment.

## How to Contribute

1. Fork the Repository

    Fork the repository by clicking the "Fork" button on the top right of this page.
    Clone your forked repository to your local machine:

    git clone https://github.com/Vexmage/EventHive.git
    cd EventHive

2. Create a Branch

    Always create a new branch for your changes to avoid affecting the main branch directly.
    Use a descriptive branch name:

    git checkout -b feature/short-description

    Examples:
        feature/authentication
        bugfix/task-sync

3. Make Your Changes

    Ensure your code follows our coding standards (see Coding Standards below).
    Test your changes locally to ensure they work as expected.
    Update documentation (if applicable) in the README.md or docs/ folder.

4. Commit Your Changes

    Write clear and concise commit messages:

    git commit -m "Fix: Resolve sync conflict in task list"

    Use prefixes like:
        Fix: for bug fixes.
        Feature: for new functionality.
        Docs: for documentation changes.

5. Push Your Changes

    Push your branch to your fork:

    git push origin feature/short-description

6. Open a Pull Request

    Navigate to the main repository and open a pull request (PR) from your branch.
    Follow the PR template and provide the following:
        A short description of your changes.
        Links to related issues or discussions (if any).
        Any testing notes.
    Example:

    ## Description
    This PR adds JWT-based authentication to the backend API.

    ## Related Issues
    Closes #12

    ## Testing Notes
    - Tested login and logout functionality.
    - Verified that token expiration works as expected.

##Coding Standards

1. General

    Use meaningful variable and function names.
    Write clear and concise comments where necessary.

2. Frontend

    Follow Blazor's component-based design principles.
    Use consistent styling conventions (e.g., Bootstrap classes).
    Ensure responsiveness across devices.

3. Backend

    Use descriptive method names for API endpoints (e.g., CreateEvent, DeleteTask).
    Return proper HTTP status codes (e.g., 201 Created, 400 Bad Request).

4. Database

    Follow the structure defined in the ERD.
    Use migrations to make changes to the database schema.

5. Linting and Formatting

    Run dotnet format (or a similar tool) to ensure consistent code formatting.

## Pull Request Process

    - Create the Pull Request
    - Ensure your PR is based on the latest version of main.
    - If your PR addresses an issue, link the issue in the description.

    ### Code Review
        - A reviewer will review your PR for functionality, readability, and adherence to standards.
        - You may be asked to make changes. Please respond promptly and update your PR.

    ### Testing
        - Ensure all tests pass. If adding new features, write appropriate tests.

    ### Merging
        - After approval, the PR will be merged into the main branch.
        - Make sure to delete your branch after merging to keep the repository clean.

## Reporting Issues

- If you encounter a bug or have a feature request:

    Check the issues page to see if it has already been reported.
    If not, create a new issue and provide:
        A clear title.
        Steps to reproduce the problem.
        Expected and actual behavior.
        Screenshots (if applicable).

### Code of Conduct

Please be respectful and professional in all interactions. 