Part 3: Creating, Updating and Deleting Book
============================================

Creating a new Book -
---------------------

In order to create a new book, we will create a new component called RdsCompBookForm. Run code below in root folder

```shell
    raaghu create:component --name=rds-comp-book-form
```

Go to following path and perform html operations

    <project path>\raaghu-components\src\rds-comp-book-form

Add following code in slice file and add builder case in extra reducer similar to fetchbooks

```javascript
  export const postNewBook = createAsyncThunk(
            "book/postNewBook",
            (model:any) => { return proxy.bookPOST(model).then((result:any)=>{
                       return result
             } ) } );
```

Here, we bring a button of a New Book using RdsButton and on clicking, we get different parameters of a form inside a RdsOffcanvas
```javascript
    <RdsOffcanvas
    offcanvasbutton={`<div>`
    <RdsButton
        type={"button"}
        label={"New Book"}
        iconColorVariant="light"
        size="small"
        colorVariant="primary"
        icon="plus"
        iconFill={false}
        iconStroke={true}
        iconHeight="12px"
        iconWidth="12px"
    >`</RdsButton>`
    `</div>`
    }
        placement={"end"}
        backDrop={true}
        scrolling={false}
        preventEscapeKey={false}
        offId={"newBook"}
        canvasTitle={"New Book"}
        offcanvaswidth={550}
        >
    <RdsCompBook
        NameProp = {""}
        TypeProp = {""}
        PublishDateProp = {""}
        PriceProp = {""}
        onSaveHandler={onNewCreate}
        offCanvasType={"create"}
        TypeEnumItems={TypeEnum}
        >`</RdsCompBook>`
    `</RdsOffcanvas>`
```
Now add this function inside book component

```javascript
   const onNewCreate = (datafromcomponent: any) => {
        let TypeIndex = datafromcomponent.data.Type
        const data = {
        name: datafromcomponent.data.Name,
        type:TypeIndex,
        publishDate: datafromcomponent.data.PublishDate.toISOString().substring(0, 19),
        price: datafromcomponent.data.Price
    }
    dispatch(postBooksRequest({requestBody:data}) as any).then((res: any) => {
    if (res.type.includes("rejected")) {
    setAlert({
                ...Alert,
                show: true,
                message: "Something went wrong",
                color: "danger",
            });
        }
        else {
                setAlert({
                    ...Alert,
                    show: true,
                    message: "Added Successfully",
                    color: "success",
                });
            }
                dispatch(getBooksRequest({}) as any);
                }).catch((error: any) => {
                setAlert({
                            ...Alert,
                            show: true,
                            message: "Something went wrong",
                            color: "danger",
                        });
            console.error(error);
        });
    };
```

### Updating a new Book -

Define the actions for Edit in the form of an array as shown below

```javascript
    const actions = [{ id: "edit", displayName: t("Edit"), offId: "BookEdit"}]
```

Update table using actions used in data table. Updated data table will look like

    <RdsCompDatatable classes="table__userTable" tableHeaders={tableHeaders} pagination={true}
        tableData={Data} actions={actions}onActionSelection={onActionSelection} recordsPerPage={5}  recordsPerPageSelectListOption={true}>`</RdsCompDatatable >`

Add following slice code inside Slice file and add builder cases similar to fetchbook

```javascript
    export const putBooksRequest = createAsyncThunk(
    'book/putBooksRequest',
    async   ({
                id,
                requestBody,
            }:{
                id: string,
                requestBody?: DemoSuite2_Books_BookUpdateDto,
            }) => {
                const response = await BookService.putBooks({
                id,
                requestBody,
            });
                return response;
            }
    );
```

Add these builder cases inside BookSlice extra reducer

```javascript
    builder.addCase(putBooksRequest.pending, (state) => {
        state.loading = true;
    });
        builder.addCase(putBooksRequest.fulfilled, (state, action) => {
        state.loading = false;
        state.error = "";
    });
        builder.addCase(putBooksRequest.rejected,(state, action)=> {
        state.loading = false;
        state.error = action.error.message || "Something went wrong";
    });
```

Add the Edit function in Book Page

```javascript
  const onEdithandler = (datafromcomponent: any) => {
    const id = dataEmit.id;
    let TypeIndex = datafromcomponent.data.Type
    function dateChange (inputdate:any)
    {
        const date = new Date(inputdate);
        const year = date.getFullYear();
        const month = (date.getMonth() + 1).toString().padStart(2, "0");
        const day = date.getDate().toString().padStart(2, "0");
        const hours = date.getHours().toString().padStart(2, "0");
        const minutes = date.getMinutes().toString().padStart(2, "0");
        const seconds = date.getSeconds().toString().padStart(2, "0");
        const formattedDate = ${year}-${month}-${day}T${hours}:${minutes}:${seconds};
        return formattedDate
    }
        const data =
    {
        concurrencyStamp : dataEmit.concurrencyStamp,
        name: datafromcomponent.data.Name,
        type:TypeIndex,
        publishDate: dateChange(datafromcomponent.data.PublishDate),
        price: datafromcomponent.data.Price
    }
        dispatch(putBooksRequest({ id: id ,requestBody: data }) as any)
            .then((res: any) => {
            setdataEmit([{}]);
            if (res.type.includes("rejected")){
            setAlert({
                ...Alert,
                show: true,
                message: "Error while updating",
                color: "danger",
            });
                }else{
                dispatch(getBooksRequest({}) as any);
                setAlert({
                ...Alert,
                show: true,
                message: "Updated Succesfully",
                color: "success",
            });
        }
    })
        .catch((error: any) => {
            setAlert({
            ...Alert,
            show: true,
            message: "Something went wrong",
            color: "danger",
        });
            console.error(error);
        });
    };
```

Add property of RdsOffcanvas element below RdsCompDatatable

```javascript
    <RdsOffcanvas
        placement={"end"}
        backDrop={true}
        scrolling={false}
        preventEscapeKey={false}
        offId={"BookEdit"}
        canvasTitle={"Edit"}
        offcanvaswidth={550}
    >
    <>
        <RdsCompBook
        NameProp = {dataEmit.name}
        TypeProp = {dataEmit.type}
        PublishDateProp = {dataEmit.publishDate}
        PriceProp = {dataEmit.price}
        offCanvasType={"update"}
        TypeEnumItems={TypeEnum}
        onSaveHandler={onEdithandler}
        >`</RdsCompBook>`
    </>
    `</RdsOffcanvas>`
```

### Deleting a new Book –

Add Edit function in Book Page

```javascript
const actions = [{ id: "Delete", displayName: t("Delete"), modalId: "bookDel" }]
                               ]
```

We now add a slice file used for Delete functionality

```javascript
   export const deleteBooksRequest = createAsyncThunk(
    'book/deleteBooksRequest',
    async   ({
                id,
            }:{
                id: string,
            }) => {
                const response = await BookService.deleteBooks({
                id,
            });                return response;
            }
    );
```

Add these builder cases inside BookSlice extra reducer

```javascript
    builder.addCase(deleteBooksRequest.pending, (state) => {
        state.loading = true;
    });
        builder.addCase(deleteBooksRequest.fulfilled, (state, action) => {
        state.loading = false;
        state.error = "";
    });
        builder.addCase(deleteBooksRequest.rejected,(state, action)=> {
        state.loading = false;
        state.error = action.error.message || "Something went wrong";
    });
```

We integrate a component called RdsCompAlertPopup to display alert during deleting a book list

```javascript
    <RdsCompAlertPopup
            alertID={"bookDel"}
            onSuccess={onDeleteHandler}
            ></RdsCompAlertPopup>
```

Add delete function in Book Page
