namespace Quera {
    public static class Configs {
        public const string SolutionUrlFormat = "https://github.com/HamidMolareza/QueraProblems/blob/{0}/Quera/Program.cs";
        public const string QueraQuestionsUrlFormat = "https://quera.org/problemset/{0}/";
        public const string ReadmeFileName = "README.md";
        public const string ReadmeTemplate = @"# QueraProblems
The answer to some [Quera](https://quera.org) problems in C#.

## List of problems
{__REPLACE_FROM_PROGRAM_0__}

## Contributing
In Quera, structure of the questions link is as follows:
https://quera.org/problemset/{Question-Index-As-Number}/

We solve each question in a separate branch. The name of that branch is the {question index} in Quera link.

For example, to solve question 1234 (https://quera.org/problemset/1234), Checkout to branch 1234, solve the problem, commit and finally send PR.

Thank you :)

## About Readme.md
This file is generated automatically. You can see the source of this program in the master branch.

If you like this project, please give it a star.

## License
[GPLv3](LICENSE.md)";
    }
}