Part 2: Book List Page
======================

Github CLI
----------

Select a local Directory and run following command inside command prompt to download and output code using a local directory name where project is converted into zip

```shell
 curl -L https://github.com/Wai-Technologies/raaghu-react/archive/development-abp.zip --output (folder name).zip
```

now, unzip file using following command

```json
    tar -xf (folder name).zip
```

### Install NPM packages

Run below code at root level of your project folder

```shell
  raaghu install-all
```

### Install Abp-React-Core

Run below code at root level of your project folder

```shell
  raaghu create:core
```

### Generate Proxy

to create proxies, we run following command at root level

```shell
  raaghu create:proxy --url=https://raaghu-react.azurewebsites.net
```

### Create a BookStore Module

Run following command line to create a new Module, named BookStore on root folder and a Book page within it of React application

```shell
  raaghu create:page --moduleName=BookStore --pageName=book --projectName=Acme.BookStore
```

**Note:Creating a page is case sensitive. name of page should be in small letters**

### Code Snippets

**Data Table**

Here we integrate a Data Table using a component RdsCompDataDable component having table headers and data corresponding to it.

code looks like as shown below
```javascript
    <RdsCompDatatable
        classes="table__userTable"
        tableHeaders={tableHeaders}
        pagination={true}
        tableData={Data}
        onActionSelection={onActionSelection}
        recordsPerPage={5}
        recordsPerPageSelectListOption={true}
    >`
    </RdsCompDatatable>`
```
in RdsCompDataTable, we can add the neccessary data we want to show in tableData and following array of actions that you require as well as neccessary function using onActionSelection

### Column Structure

Now we integrate table headers in data table 

```bash 
const tableHeaders = [
    {
        "displayName": "NAME",
        "name": "Name",
        "key": "name",
        "datatype": "text",
        "sortable": true,
        "element": "RdsInput"
    },
    {
        "displayName": "TYPE",
        "name": "Type",
        "key": "type",
        "datatype": "text",
        "sortable": true,
        "element": "RdsSelectList"
    },
    {
        "displayName": "PUBLISHDATE",
        "name": "PublishDate",
        "key": "publishDate",
        "datatype": "text",
        "sortable": true,
        "element": "RdsDatePicker"
    },
    {
        "displayName": "PRICE",
        "name": "Price",
        "key": "price",
        "datatype": "text",
        "sortable": true,
        "element": "RdsInput"
    }
    ]
```

### Adding a Slice File
We now add a slice file that defines a piece of state and its corresponding reducer functions    

```shell
export const getBooksRequest = createAsyncThunk(
    'book/getBooksRequest',
    async ({
        filterText,
        name,
        type,
        publishDateMin,
        publishDateMax,
        priceMin,
        priceMax,
        sorting,
        skipCount,
        maxResultCount,
    }:{
        filterText?: string,
        name?: string,
        type?: DemoSuite2_Books_BookType,
        publishDateMin?: string,
        publishDateMax?: string,
        priceMin?: number,
        priceMax?: number,
        sorting?: string,
        skipCount?: number,
        maxResultCount?: number,
    }) => {
        const response = await BookService.getBooks({
        filterText,
        name,
        type,
        publishDateMin,
        publishDateMax,
        priceMin,
        priceMax,
        sorting,
        skipCount,
        maxResultCount,
    });        return response;    }
    );

```

Add these builder cases inside BookSlice extra reducer

```shell
    builder.addCase(getBooksRequest.pending, (state) => {
        state.loading = true;
    });
        builder.addCase(getBooksRequest.fulfilled, (state, action) => {
        state.loading = false;
        state.error = "";
        state.getBooks = action.payload
    });        builder.addCase(getBooksRequest.rejected,(state, action)=> {
        state.loading = false;
        state.error = action.error.message || "Something went wrong";
    });
```

We now perform fetching data in Books Page and displaying it inside data table

```shell
    useEffect(() => {
        dispatch(getBooksRequest({}) as any);
    }, []);
```

### The Next Part

* See the [next part](Creating-Updating-And-Deleting-Book.md) of this tutorial.
