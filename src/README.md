# Start a new project in Xamarin Shell
Use this repo to easy start your project with Xamarin.Forms Shell features!

## What I've done
1. Create a folder with a src folder inside, a .gitignore file made at [gitignore.io](gitignore.io) and a README.md like this
2. Create with Visual Studio a new starter project with Shell for all platforms you need
3. Clean solution from all mock files
4. Add simple nuget packages from stable channel and update olders
5. Add Resources folder with a Font folder inside with all fonts you need, like FontAwesome or MaterialDesign
  a. You have to add Export Fonts instruction to AssemblyInfo too
6. Refactor AppShell.xaml file with new awesome icon and pages
7. Migrate to AndroidX libraries.

### Feature branches
In features branch I'll put new experiments I do with some interesting, but not required, packages from Xamarin community.

For example: in the branch **App Actions** you can find a sample project, clone of the main project, where I use the App Actions feature and you can try it.


## What you've to do
1. Create a LoginPage to show before access Shell Items
2. Create a Settings Page for language or themes
3. Enrich AboutPage with your data.

### How to contribute
You can open a pull request to merge your personal feature or a fix bugs. You can open an issue to discuss about Xamarin interesting packages to add and ask for an implementation in a new feature branch. Please, follow templates proposed and feel free to improve them if you think is useful.