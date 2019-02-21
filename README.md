# VRBrawlers

**Get started**

**Installing GIT LFS**

1.  For Mac users, install Git LFS using [Homebrew](http://brew.sh/). Then go into your local repository and run `brew install git-lfs`
2.  For Windows users, download the installer from [official website](https://git-lfs.github.com/) and run. After installation, run `git lfs install` in your local repository.
3. Create new file called `.gitattributes` and copy the following into the file to get you starter. Feel free to add more file extensions and update this README.

``` *.fbx filter=lfs diff=lfs merge=lfs -text

*.psd filter=lfs diff=lfs merge=lfs -text

*.png filter=lfs diff=lfs merge=lfs -text

*.mp3 filter=lfs diff=lfs merge=lfs -text

*.wav filter=lfs diff=lfs merge=lfs -text

*.prefab filter=lfs diff=lfs merge=lfs -text

*.xcf filter=lfs diff=lfs merge=lfs -text
```


**Clone the repository**

*  Prepare project folder
   *  create an empty Unity project
   *  quit Unity
   *  **Important** : delete ProjectSetting folder
* Prepare the git repo
   *  run `git init` to make this project a git repo
   *  run `git remote add origin "git@gitlab.doc.gold.ac.uk:halsi001/nice.git"`
   *  pull remote bran `origin/master` to local branch master
   *  run `git branch dev` to create a new local branch for developing
   *  run `git checkout dev` to switch into local dev branch
   *  pull remote branch `origin/dev` into local dev branch
