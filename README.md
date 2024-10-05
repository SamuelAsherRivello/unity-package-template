[![npm package](https://img.shields.io/npm/v/com.rmc.your-package-name)](https://www.npmjs.com/package/com.rmc.unity-package-template)
[![License: MIT](https://img.shields.io/badge/License-MIT-green.svg)](https://opensource.org/licenses/MIT)

# RMC Unity Package Template

> Fork this repo and update all contents including `Readme.md` and `Package.json` to create and release a new UPM-compatible Unity package.

<BR>

<img width = "600" src="https://raw.githubusercontent.com/SamuelAsherRivello/rmc-core/main/RMC%20Core/Documentation~/com.rmc_namespace_logo.png" />

<BR>
<BR>

# Contents

1. [Install](#install)
1. [Configuration](#configuration)
1. [Testing](#testing)
1. [Credits](#credits)

<BR>
<BR>

## Install

You can either install [Via NPM](#via-npm) or [Via Git URL](#or-via-git-url). The result will be the same.

### Via NPM

You can either use the Unity Package Manager Window (UPM) or directly edit the manifest file. The result will be the same.

**UPM**

To use the [Package Manager Window](https://docs.unity3d.com/Manual/upm-ui.html), first add a [Scoped Registry](https://docs.unity3d.com/2023.1/Documentation/Manual/upm-scoped.html), then click on the interface menu ( `Status Bar → (+) Icon → Add Package By Name ...` ).

**Manifest File**

Or to edit the `Packages/manifest.json` directly with your favorite text editor, add a scoped registry then the following line(s) to dependencies block:

```json
{
  "scopedRegistries": [
    {
      "name": "npmjs",
      "url": "https://registry.npmjs.org/",
      "scopes": ["com.rmc"]
    }
  ],
  "dependencies": {
    "com.rmc.your-package-name": "1.8.0"
  }
}
```

Package should now appear in package manager.

### Or Via Git URL

You can either use the Unity Package Manager (UPM) Window or directly edit the manifest file. The result will be the same.

**UPM**

To use the [Package Manager Window](https://docs.unity3d.com/Manual/upm-ui.html) click on the interface menu ( `Status Bar → (+) Icon → Add Package From Git Url ...` ).

**Manifest File**

Or to edit the `Packages/manifest.json` directly with your favorite text editor, add following line(s) to the dependencies block:

```json
{
  "dependencies": {
    "com.rmc.your-dependency-here": "https://github.com/SamuelAsherRivello/your-dependency-here.git"
  }
}
```

<BR>
<BR>

## Configuration

- `Unity Target` - [Standalone MAC/PC](https://support.unity.com/hc/en-us/articles/206336795-What-platforms-are-supported-by-Unity-)
- `Unity Version` - Any [Unity Editor](https://unity.com/download) 2021.x or higher
- `Unity Rendering` - Any [Unity Render Pipeline](https://docs.unity3d.com/Manual/universal-render-pipeline.html)
- `Unity Aspect Ratio` - Any [Unity Game View](https://docs.unity3d.com/Manual/GameView.html)

<BR>
<BR>

## Testing

The package can optionally be set as _testable_.
In practice this means that tests in the package will be visible in the [Unity Test Runner](https://docs.unity3d.com/2017.4/Documentation/Manual/testing-editortestsrunner.html).

Open `Packages/manifest.json` with your favorite text editor. Add following line **after** the dependencies block:

```json
{
  "dependencies": {},
  "testables": ["com.rmc.your-package-name"]
}
```

### Samples

Some packages include optional samples with clear use cases. To import and run the samples:

1. Open Unity
1. Complete the package installation (See above)
1. Open the [Package Manager Window](https://docs.unity3d.com/Manual/upm-ui.html)
1. Select this package
1. Select samples
1. Import

<BR>
<BR>

## Credits

**Created By**

- Samuel Asher Rivello
- Over 26 years XP with game development (2025)
- Over 12 years XP with Unity (2025)

**Contact**

- Twitter - <a href="https://twitter.com/srivello/">@srivello</a>
- Git - <a href="https://github.com/SamuelAsherRivello/">Github.com/SamuelAsherRivello</a>
- Resume & Portfolio - <a href="http://www.SamuelAsherRivello.com">SamuelAsherRivello.com</a>
- LinkedIn - <a href="https://Linkedin.com/in/SamuelAsherRivello">Linkedin.com/in/SamuelAsherRivello</a> <--- Say Hello! :)

**License**

Provided as-is under <a href="./LICENSE">MIT License</a> | Copyright ™ & © 2006 - 2025 Rivello Multimedia Consulting, LLC
