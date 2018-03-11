# unity-3rdparty-sqlite-net

This is a straight port of sqlite-net to unity3d as an installable package.

See https://github.com/praeclarum/sqlite-net for details on that project.

Some examples can be found in the `tests` folder.

The tagged release version here matches the tagged releases of that project.

This is *not* a modified version of sqlite-net; you must use the 4.6+ runtime to use it.

For 'safe' use (eg. dealing with reflection in IOT contexts), please use a higher level api wrapper.

## Install

From your unity project folder:

    npm init
    npm install shadowmint/unity-3rdparty-sqlite-net --save
    echo Assets/packages >> .gitignore
    echo Assets/packages.meta >> .gitignore

The package and all its dependencies will be installed in
your Assets/packages folder.

### Tests

Run `npm install` in the tests folder to install dependencies.
