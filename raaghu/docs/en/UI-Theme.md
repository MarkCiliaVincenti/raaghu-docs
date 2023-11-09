# Raaghu React Theme

**Raaghu React Theme** is pre-installed in the Source code. So, no need to manually install it.
npm package is directly installed in project level as you seen in root level **package.json** file and inside raaghumfe folder.

````shell
npm i raaghu-react-themes
````
![package](images/raaghu-react-theme-package.png)


# Customize Raaghu React Theme

### How to use raaghu-react-themes 

get source code from repository, put on root level directory of project.

In the following folder, you will find all the **Raaghu React Theme**.

![folder structure](images/raaghu-theme-folder.png)

### Project Level

Steps to follow if you want to customize css , color-variables , adding new classes according to your customize theme.

On root level you will see **raaghu-mfe** folder inside that go to

```json
rds-pages > host > src > App.scss
```

you will get to see below line

```json
@import "../../../../raaghu-react-themes/src/styles/default.scss";
```
![app file](images/raaghu-react-theme-app.png)

using above line you can access the raaghu-react-themes folder as you are applying all themes related things through 
**default.scss** file in theme that's why we are pointing to default.scss file.

Inside raaghu-react-themes you will get to see two folders like Public and src
![folder structure](images/raaghu-theme-folder.png)

If you want to make changes for fonts you can go to fonts folder inside **public** folder -

![fonts changes](images/raaghu-react-public.png)

If you want to customize element css for application you can go to **styles** folder inside src folder - 

![project css](images/raaghu-theme-style.png)


