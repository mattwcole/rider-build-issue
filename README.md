# rider-build-issue

Verify that the demo app is working.
```sh
git clone https://github.com/mattwcole/rider-build-issue.git
cd rider-build-issue/RiderBuildIssue
dotnet restore
dotnet run
```
Clean the repo.
```sh
git clean -xdf
```
Open solution in Rider and wait for package restore to finish. Solution will no longer build (in Rider or from command line).
