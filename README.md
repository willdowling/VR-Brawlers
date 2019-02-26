# VRBrawlers

**Get started**

**Installing GIT LFS**

1.  For Mac users, install Git LFS using [Homebrew](http://brew.sh/). 
2.  For Windows users, download the installer from [official website](https://git-lfs.github.com/) and run.


**Clone the repository**

* Prepare the git repo
   *  run `git init` to make this project a git repo
   *  run `git lfs install` on Windows or run `brew install git-lfs` on Mac
   *  run `git remote add origin "git@gitlab.com:nice-company/vrbrawlers.git"`
   *  run `git pull origin master` 
   *  run `git pull origin develop`
   *  run `git checkout develop` to switch into local dev branch
   *  create a new branch with `git branch feature/[branch name]` to start developing

**Known errors**

* If Unity editor keeps asking you to update OVR Plugin and restart do the following:
    * Go to the Asset Store and search for "Oculus Integration"
    * Click download and then import
    * When prompted with the Unity Package windows to select items to be imported, only tick the boxes to Plugins/Win/OVRPlugin.dll and Plugins/Win64/OVRPlugin.dll
     ![](https://cdn.discordapp.com/attachments/496427838744952868/549960224992264212/unknown.png)
    * Click "Import", wait for it to finish, then restart Unity and update OVRPlugin. Restart again and it should be fixed.
