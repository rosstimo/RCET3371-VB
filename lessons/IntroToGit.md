# Git Lesson Plan

## Table of Contents
1. Introduction to Version Control
2. Setting Up Git
3. Understanding Git Fundamentals
4. Working with Changes
5. Branching and Merging
6. Remote Collaboration
7. Common Scenarios and Issues
8. Advanced Git Concepts
9. Hands-on Practice and Exercises
10. Resources for Continued Learning
11. Assessment and Review
12. References

---

### 1. Introduction to Version Control

#### What is Version Control?
Version Control is a system that records changes to a file or set of files over time, allowing you to recall specific versions later. It is particularly useful for collaborative projects, tracking changes, and ensuring project integrity.

**Types of Version Control Systems (VCS):**
- **Local VCS:** Keeps track of changes locally, but can be error-prone.
- **Centralized VCS (CVCS):** Uses a single server for all version tracking, which simplifies collaboration but introduces a single point of failure.
- **Distributed VCS (DVCS):** Every contributor has a full copy of the project history, which allows for offline work and redundancy. Git is an example of a DVCS.

#### Why Git?
Git is a Distributed Version Control System (DVCS) designed for flexibility, performance, and collaboration. Its key benefits include fast operations, distributed architecture, and strong branching and merging capabilities.

---

### 2. Setting Up Git

#### Installing Git
- **Windows:** Download the installer from [git-scm.com](https://git-scm.com/).
- **Linux:** Use your package manager (e.g., `sudo apt install git`).
- **macOS:** Install via Homebrew with `brew install git`.

#### Configuration Basics
- **Set User Identity:**
  ```sh
  git config --global user.name "Your Name"
  git config --global user.email "your.email@example.com"
  ```
- **Set Default Editor:**
  ```sh
  git config --global core.editor "vim"
  ```

---

### 3. Understanding Git Fundamentals

#### Repositories and Commits
- **Repository (Repo):** A directory that holds all the files, folders, and complete history of your project.
- **Creating a New Local Repository**
  1. **Initialize a Repository:**
     To create a new repository, navigate to your project directory and run:
     ```sh
     mkdir my_project
     cd my_project
     git init
     ```
     This creates a new Git repository in the `my_project` directory.
     
  2. **Create a New File:**
     Create a new text file and add some content:
     ```sh
     echo "Hello, Git!" > file1.txt
     ```
     
  3. **Check Repository Status:**
     Use `git status` to see the current state of your working directory:
     ```sh
     git status
     ```
     You should see `file1.txt` listed as an untracked file.
     
  4. **Stage the File:**
     Add `file1.txt` to the staging area:
     ```sh
     git add file1.txt
     ```
     Run `git status` again to confirm that `file1.txt` is now staged.
     
  5. **Commit the File:**
     Commit the staged changes with a descriptive message:
     ```sh
     git commit -m "Add file1.txt with initial content"
     ```
     This creates a commit that saves the state of `file1.txt` to the repository.

     **Commit Messages:** Commit messages should be informative and clearly describe what changes were made and why. Good commit messages make it easier for others (and your future self) to understand the history of the project.

     **Examples of Good vs. Less Good Commit Messages:**
     - **Good:** "Add initial content to file1.txt"
     - **Good:** "Update file1.txt to include a second line explaining usage"
     - **Less Good:** "Updated file"
     - **Less Good:** "Fix"

     A good commit message should be concise, yet descriptive enough to convey the context of the change.
     
  6. **Modify the File and Create Another Commit:**
     Edit `file1.txt` to add more content:
     ```sh
     echo "This is the second line." >> file1.txt
     ```
     Check the status to see the changes:
     ```sh
     git status
     ```
     You will see `file1.txt` listed as modified.
     
  7. **Stage and Commit the Changes:**
     Stage the modified file:
     ```sh
     git add file1.txt
     ```
     Commit the changes:
     ```sh
     git commit -m "Update file1.txt with a second line"
     ```
     When writing commit messages, remember to describe what was changed and why.
     - **Good Example:** "Update file1.txt to add additional usage instructions"
     - **Less Good Example:** "Edited file1.txt"
     
  8. **Repeat to Build Commit History:**
     Create another file:
     ```sh
     echo "This is another file." > file2.txt
     ```
     Stage and commit the new file:
     ```sh
     git add file2.txt
     git commit -m "Add file2.txt"
     ```
     
  9. **Viewing Commit History:**
     Use `git log` to see the history of your commits:
     ```sh
     git log
     ```
     This will show a list of commits, including the commit messages, authors, and timestamps.

#### .gitignore Usage
The `.gitignore` file is used to specify files and directories that Git should ignore to keep the repository clean.
- **Purpose:** Exclude unnecessary files like build artifacts, logs, or sensitive information from version control.
- **Common Patterns and Examples:**
  - **Ignore Log Files:**
    ```
    *.log
    ```
    This pattern ignores all files with the `.log` extension, such as `debug.log` or `application.log`.
  - **Ignore Build Directories:**
    ```
    build/
    dist/
    ```
    These lines ignore the entire `build` and `dist` directories, which are typically used for compiled files or distribution packages.
  - **Ignore Operating System Files:**
    ```
    .DS_Store  # macOS metadata
    Thumbs.db  # Windows image cache
    ```
    These entries ignore metadata files created by operating systems.
  - **Ignore Environment Files:**
    ```
    .env
    ```
    This line ignores `.env` files that often contain sensitive environment variables.
  - **Ignore IDE and Editor Files:**
    ```
    *.swp    # Vim swap files
    .vscode/ # Visual Studio Code settings
    *.idea/  # IntelliJ IDEA project settings
    ```
    These lines prevent editor-specific settings or temporary files from being included in the repository.
  - **Negating Patterns:**
    ```
    *.log
    !important.log
    ```
    The first line ignores all `.log` files, but the second line ensures that `important.log` is not ignored.

- **Best Practices:**
  - **Project-Specific Files:** Tailor `.gitignore` to include files specific to your project's environment and tools.
  - **Global Ignore File:** For files common across all projects (like OS-specific files), use a global ignore file set up via `git config --global core.excludesfile <file>`.
  - **Use Templates:** Start with templates available for various languages and frameworks to ensure comprehensive coverage of common ignore patterns.

---

### 4. Working with Changes

#### Exploring Git History
- **Restoring Files to a Previous Commit**:
  - Use `git checkout <commit-hash> -- <file-path>` to restore a specific file to its state in a previous commit. This is useful for rolling back changes to individual files.
  - **Example**:
    ```sh
    git checkout abc1234 -- file1.txt
    ```
    This command restores `file1.txt` to the version from the commit with hash `abc1234`.
  - After restoring, you can commit the changes if you want to keep them:
    ```sh
    git add file1.txt
    git commit -m "Restore file1.txt to previous version"
    ```

- **Exploring Files and Their Content**:
  - Use `git show <commit-hash>:<file-path>` to explore the content of a file at a particular commit without modifying your working directory.
  - **Example**:
    ```sh
    git show abc1234:file1.txt
    ```
    This command displays the content of `file1.txt` as it was in the commit with hash `abc1234`.

- **Returning to the Current State**:
  - If you checked out a previous commit or restored files to an older state, you can return to the latest commit on your branch by using:
    ```sh
    git checkout main
    ```
    This command will move you back to the `main` branch, restoring the current state of all files.
    
- **Practical Example**:
  - Suppose you accidentally made some changes to `file1.txt` that you don't want to keep. You can:
    1. Use `git log` to find the commit hash where `file1.txt` was last correct.
    2. Use `git checkout <commit-hash> -- file1.txt` to restore that version.
    3. Stage and commit the restored version if needed.

- **Viewing History**:
  - Use `git log` to display the commit history. By default, `git log` shows each commit in reverse chronological order (most recent first).
  - **Customizing Log Output**:
    - Use `git log --oneline` to show each commit on a single line, providing a compact overview.
    - Use `git log --graph` to display a visual representation of the branch structure and merges.
    - Combine options like `git log --oneline --graph` to create a visual summary of the history.
  - **Filtering Commits**:
    - To view commits by a specific author, use `git log --author="Author Name"`.
    - To limit commits by date, use options like `--since` and `--until`:
      ```sh
      git log --since="2023-01-01" --until="2023-12-31"
      ```
    - To search for keywords in commit messages, use `--grep`:
      ```sh
      git log --grep="fix"
      ```
  - **Viewing Changes**:
    - Use `git show <commit-hash>` to view the details of a specific commit, including the changes made.
    - Use `git diff` to see the differences between commits or between the working directory and the latest commit.
    - To view changes between two specific commits, use:
      ```sh
      git diff <commit-hash1> <commit-hash2>
      ```
- **Practical Examples**:
  - After making multiple commits, running `git log` provides a complete overview of all changes.
  - Use `git log --stat` to display statistics for each commit, such as the number of files changed and lines added/removed.
  - For a more detailed history, use `git log --pretty=format:"%h - %an, %ar : %s"` to customize how each commit is displayed.

#### Exploring Git History
- **Viewing History:**
  - `git log` displays commit history.
  - Use `--oneline` or `--graph` for compact or visual representations.

#### Undoing Changes
- **Unstage Files:** Use `git reset [file]`.
- **Amend Commits:** Modify the last commit with `git commit --amend`.
- **Stashing Changes:** Temporarily save changes with `git stash`.

---
### 5. Branching and Merging (Expanded)

#### Branches Explained
Branches are essentially different versions of your project that coexist in parallel. This allows developers to work on features, fixes, or experiments without affecting the main codebase. The main branch in Git is commonly called `main` or `master`. Creating branches is a core part of Git's power, enabling collaborative workflows and feature isolation.

- **Why Use Branches?**
  - **Isolate Features:** Each feature or bug fix can be developed in its own branch, keeping the main branch clean and functional.
  - **Parallel Development:** Multiple developers can work on different features simultaneously without interfering with each other's code.
  - **Testing and Experimentation:** Branches make it safe to experiment. If something goes wrong, the main branch remains unaffected.

A common approach is **Git Flow**, where developers use separate branches for new features (`feature/branch-name`), bug fixes (`hotfix/branch-name`), and releases (`release/branch-name`). This allows structured and organized project development.

#### Branch Operations

##### 1. Create a Branch
To create a new branch, you use the `git branch` command followed by the branch name:
```sh
git branch feature-xyz
```
This command creates a new branch named `feature-xyz` based on your current branch. However, you will still be on the original branch (e.g., `main`). To start working on the new branch, you need to switch to it.

##### 2. Switch Branch
To move to another branch, you use the `git checkout` command:
```sh
git checkout feature-xyz
```
Alternatively, with newer versions of Git, you can use the more intuitive `git switch`:
```sh
git switch feature-xyz
```
Now you are on the `feature-xyz` branch, and any changes you make will be specific to this branch.

##### 3. Create and Switch in One Step
You can also create and switch to a new branch in a single step using:
```sh
git checkout -b feature-xyz
```
or:
```sh
git switch -c feature-xyz
```
This is a handy way to streamline your workflow when starting new features.

##### 4. Merge Branch
Once you have finished working on a branch, you often want to merge those changes back into the `main` branch. You first switch back to `main` and then use the `git merge` command:
```sh
git checkout main
git merge feature-xyz
```
This will integrate the changes from `feature-xyz` into `main`. If there are no conflicting changes, Git will perform a **fast-forward merge** or an **automatic merge**.

- **Fast-Forward Merge**: If no new commits have been made on `main` since you branched off, Git will simply move the pointer of `main` forward, effectively integrating all changes without creating a merge commit.
- **Three-Way Merge**: If new commits were made on `main` while you were working on `feature-xyz`, Git will create a new commit that reconciles changes from both branches, preserving the full history.

##### 5. Merge Conflicts
Merge conflicts occur when changes in different branches affect the same part of a file. Git cannot automatically determine which change should be kept, so it will ask for manual intervention.

**Example Scenario: Resolving a Conflict**
- Suppose you have two branches: `main` and `feature-a`.
- Both branches have modified the same line in `file.txt`.
- When you attempt to merge `feature-a` into `main`, Git reports a conflict:
  ```sh
  git merge feature-a
  # Output: CONFLICT (content): Merge conflict in file.txt
  ```

- To resolve the conflict, open `file.txt` in your editor. You will see markers that look like this:
  ```
  <<<<<<< HEAD
  Line from the main branch
  =======
  Line from feature-a
  >>>>>>> feature-a
  ```
- Choose which version to keep, or combine them manually, then save the file.
- After resolving the conflict, add the resolved file to the staging area:
  ```sh
  git add file.txt
  ```
- Finally, complete the merge by committing:
  ```sh
  git commit -m "Merge feature-a with conflict resolution"
  ```

##### 6. Deleting Branches
Once a feature branch has been merged into `main`, it is good practice to delete it to keep your branch list tidy:
```sh
git branch -d feature-xyz
```
The `-d` flag stands for "delete." This will only delete branches that have already been merged. If the branch hasn’t been merged, Git will warn you. To force delete an unmerged branch, use `-D` instead:
```sh
git branch -D feature-xyz
```
However, be careful with this, as it will remove any unmerged work permanently.

#### Rebasing vs. Merging

##### Merging
Merging is a straightforward way to combine branches. It creates a merge commit and preserves the complete history of all branches.
- **Pros**:
  - Easy to understand and use.
  - Keeps a detailed history of how changes were integrated.
- **Cons**:
  - History can become cluttered with many merge commits, especially when there are multiple active branches.

##### Rebasing
Rebasing, on the other hand, re-applies your branch's commits on top of another branch. For example, to rebase `feature-xyz` onto `main`:
```sh
git checkout feature-xyz
git rebase main
```
This process rewrites the commit history of `feature-xyz`, creating a linear sequence of commits.

- **Pros**:
  - Clean, linear history that is easy to understand.
  - No merge commits.
- **Cons**:
  - History is rewritten, which can be problematic if others are working on the same branch.
  - Not recommended for public branches, as it changes the commit hashes.

##### Interactive Rebase
Interactive rebase (`git rebase -i`) allows you to edit, squash, or reorder commits during the rebase process. This is useful for cleaning up your commit history before merging into the main branch.

**Example: Interactive Rebase**
- Suppose your branch has several commits that need to be cleaned up before merging:
```sh
git rebase -i HEAD~4
```
  This command will open an editor with the last 4 commits. You can choose to squash commits (combine them), reword commit messages, or reorder them.

#### Resolving Rebase Conflicts
Similar to merging, rebasing can also lead to conflicts if the same lines were modified. Git will pause the rebase and prompt you to resolve the conflicts.

To continue rebasing after resolving conflicts:
```sh
git rebase --continue
```
To abort the rebase and return to the original branch state:
```sh
git rebase --abort
```

#### Practical Example: Feature Development Workflow
1. **Create a Branch for Your Feature**
   ```sh
   git checkout -b feature-login
   ```
2. **Make Changes and Commit**
   ```sh
   # Edit files
   git add .
   git commit -m "Add initial login functionality"
   ```
3. **Push Your Branch to a Remote Repository**
   ```sh
   git push origin feature-login
   ```
4. **Open a Pull Request**
   Create a pull request on GitHub (or another Git hosting service) to merge your changes into `main`.
5. **Review and Merge**
   Once reviewed and approved, you can merge the feature branch into `main` and delete it.
6. **Delete the Branch Locally and Remotely**
   ```sh
   git branch -d feature-login
   git push origin --delete feature-login
   ```

#### Summary
Branching and merging are critical parts of any Git workflow, providing flexibility, safety, and collaboration for teams of all sizes. Whether you are using feature branches for parallel development or relying on rebasing to maintain a clean commit history, understanding these operations deeply will help you get the most out of Git.


### 5. Branching and Merging

#### Branches Explained
Branches allow you to work on different parts of a project without affecting the main codebase. This encourages parallel development.

#### Branch Operations
- **Create Branch:** `git branch branch-name`
- **Switch Branch:** `git checkout branch-name`
- **Merge Branch:** `git merge branch-name` to integrate changes.
- **Rebasing:** Use `git rebase` to create a linear history for easier navigation.

#### Resolving Merge Conflicts
Merge conflicts occur when changes in different branches affect the same part of a file. Resolve conflicts by manually editing the file, using `git mergetool`, then committing the resolved changes.

---

### 6. Remote Collaboration

#### Remote Repositories and GitHub
- **Adding Remote:** Use `git remote add origin [url]` to add a remote repository.
- **Pushing to Remote:** Use `git push` to upload changes.
- **Pulling from Remote:** Use `git pull` to fetch and merge changes.

#### Forking and Pull Requests
- **Forking:** Create a personal copy of someone else's repository.
- **Pull Requests:** Request to merge your changes into the original project.

---

### 7. Common Scenarios and Issues

#### Common Problems and Solutions
- **Merge Conflicts**: Use `git mergetool` or manually resolve conflicts.
- **Detached HEAD**: Checkout an existing branch or create a new branch to resume a normal state.
- **Accidental Deletion of Branches**: Use `git reflog` to recover lost branches.

#### Best Practices
- **Frequent Commits:** Make commits frequently with descriptive messages.
- **Use Branches:** Keep feature and experimental work in separate branches.

---

### 8. Advanced Git Concepts

#### Git Bisect for Bug Hunting
Use `git bisect` to find the commit that introduced a bug by performing a binary search.

#### Cherry-pick and Rebase
- **Cherry-pick:** Apply changes from a specific commit to the current branch.
- **Rebase:** Reapply commits on top of another branch to maintain a clean project history.

---

### 9. Hands-on Practice and Exercises
- **Set Up a Repository**: Create a new repository, add some files, and create commits.
- **Branching Exercise**: Create a feature branch, make changes, and merge it back.
- **Conflict Resolution Practice**: Simulate and resolve a merge conflict.

---

### 10. Resources for Continued Learning
- **Official Git Documentation**: [Git Book](https://git-scm.com/book/en/v2)
- **Interactive Tutorials**: [Learn Git Branching](https://learngitbranching.js.org/)
- **Glossary of Terms**: Refer to the glossary section for terminology.

---

### 11. Assessment and Review
- **Quiz**: Short quiz on Git commands and their use cases.
- **Group Exercise**: Collaboratively create and merge branches in a shared repository.

---

### 12. References
- Information gathered from official Git documentation, community contributions, and uploaded notes.

