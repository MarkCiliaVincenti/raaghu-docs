File Management Module
======================

This module is used to upload, download and organize files in a hierarchical folder structure. It is also compatible to multi-tenancy and you can determine total size limit for your tenants.

This module is based on the [BLOB Storing](https://docs.abp.io/en/abp/latest/Blob-Storing) system, so it can use different storage providers to store the file contents.

See [the module description page](https://commercial.abp.io/modules/Volo.FileManagement) for an overview of the module features.

React-UI
--------

File Management module is based on the [BLOB Storing](https://docs.abp.io/en/abp/latest/Blob-Storing) system as defined before, and it uses FileManagementContainer as a BLOB container.

Setting BLOB Provider
---------------------

File Management module is based on the [BLOB Storing](https://docs.abp.io/en/abp/latest/Blob-Storing) system as defined before, and it uses FileManagementContainer as a BLOB container.

You must set a BLOB provider for FileManagementContainer.

```C#
  Configure(options =>
            {
                options.Containers.Configure(c =>
                    {
                        c.UseDatabase(); // You can use FileSystem or Azure providers also.
                    });
                });
```


Please check the [BLOB Storage Providers documentation](https://docs.abp.io/en/abp/latest/Blob-Storing#blob-storage-providers) for more information about providers and how to use them.

### Packages

This module follows the [module development best practices guide](https://docs.abp.io/en/abp/latest/Best-Practices/Index) and consists of several NuGet and NPM packages. See the guide if you want to understand the packages and relations between them.

You can visit [File Management module package list](https://abp.io/packages?moduleName=Volo.FileManagement) page to see list of packages related with this module.

### User Interface

### Menu Items

File Management module adds the following items to the "Main" menu, under the "Administration" menu item:

* **File Management**: List, view all folder structure and files.

FileManagementMenuNames class has the constants for the menu item names.

### Pages

File Management

File Management page is used to create folders, upload files and view the list of folders and files that stored in the application.

![File Management page is used to create folders, upload files and view the list of folders](./images/file-management.png)

### Folders

You can create a new folder by clicking Create Folder button that located at top right on the page. The folder will be created at active directory.

![You can create a new folder by clicking Create Folder button that located at top right on the page. The folder will be created at active directory.](./images/file-management-new.png)

You can move a folder to another directory on the left tree view.

![You can move a folder to another directory on the left tree view](./images/file-management-move.png)

You can rename a folder by clicking Actions -> Rename on the table.

![You can rename a folder](./images/file-management-rename.png)

### Files

You can upload files by clicking Upload Files button that located at top right on the page. This will open a new modal for selecting your local files to upload. The files will be uploaded at active directory.

![You can upload files by clicking Upload Files button that located at top right on the page](./images/file-management-upload.png)

You can move files by clicking Actions -> Move on the data table.

![You can move files by clicking Actions Move on the data table.](./images/file-management-move.png)

You can rename a file by clicking Actions -> Rename on the data table.

![You can rename a file by clicking Actions Rename on the data table](./images/file-management-rename-edit.png)

### Data Seed

This module doesn't seed any data.

### Internals

#### Domain Layer

Aggregates

This module follows the [Entity Best Practices &amp; Conventions](https://docs.abp.io/en/abp/latest/Best-Practices/Entities) guide.

#### TextTemplateContent

* DirectoryDescriptor (aggregate root): Represents a folder.
* FileDescriptor (aggregate root): Represents a file.

Repositories

This module follows the [Repository Best Practices &amp; Conventions](https://docs.abp.io/en/abp/latest/Best-Practices/Repositories) guide.

Following custom repositories are defined for this module:

* IDirectoryDescriptorRepository
* IFileDescriptorRepository

Domain Services

This module follows the [Domain Services Best Practices &amp; Conventions](https://docs.abp.io/en/abp/latest/Best-Practices/Domain-Services) guide.

#### Directory Manager

DirectoryManager is used to manage your folders like create, rename, move and delete.

#### FileManager

DirectoryManager is used to manage your folders like create, rename, move and delete.

#### Settings

This module doesn't define any setting.

#### Features

You can enable or disable this module for each tenant, also you can set maximum storage size for each tenant. See the FileManagementFeatures class members for all features defined for this module.

#### Application Layer

Application Services

* DirectoryDescriptorAppService (implements IDirectoryDescriptorAppService): Implements the use cases of the file management UI.
* FileDescriptorAppServiceFileDescriptorAppService (implements IFileDescriptorAppService): Implements the use cases of the file management UI.

#### Database Providers

Common

#### Table/Collection Prefix & Schema

All tables/collections use the Fm prefix by default. Set static properties on the FileManagementDbProperties class if you need to change the table prefix or set a schema name (if supported by your database provider).

#### Connection String

This module uses FileManagement for the connection string name. If you don't define a connection string with this name, it fallbacks to the Default connection string.

See the [connection strings](https://docs.abp.io/en/abp/latest/Connection-Strings) documentation for details.

Entity Framework Core

#### Tables

* **FmDirectoryDescriptors**
* **FmFileDescriptors**

MongoDB

#### Collections

* **FmDirectoryDescriptors**
* **FmFileDescriptors**

MongoDB

#### Permissions

See the FileManagementPermissions class members for all permissions defined for this module.
