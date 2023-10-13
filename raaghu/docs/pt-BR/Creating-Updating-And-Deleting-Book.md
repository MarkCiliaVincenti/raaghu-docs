# parte 3: criação, atualização e ⁇  do livro
## criando um novo livro -
Para ⁇  um novo livro, vamos ⁇  um novo componente ⁇  RdsCompBookForm. Executar código abaixo na pasta root

        raaghu create:component --name=rds-comp-book-form

Ir para o ⁇  seguinte e realizar html ⁇

    &lt;project path&gt;\raaghu-components\src\rds-comp-book-form

Adicionar o seguinte código no arquivo de fatia e ⁇  a ⁇  do construtor em extra ⁇  ⁇  aos fetchbooks

      export const postNewBook = createAsyncThunk(
                "book/postNewBook",
                (model:any) =&gt; { return proxy.bookPOST(model).then((result:any)=&gt;{
                           return result
                 } ) } );

Aqui, trazemos um ⁇  de um Novo Livro usando RdsButton e, clicando, obtemos diferentes ⁇  de um formulário dentro de um RdsOffcanvas

        <rdsoffcanvas offcanvasbutton="{`<div">`
        <rdsbutton type="{&quot;button&quot;}" label="{&quot;New" book"}="" iconcolorvariant="light" size="small" colorvariant="primary" icon="plus" iconfill="{false}" iconstroke="{true}" iconheight="12px" iconwidth="12px">`</rdsbutton>`
        ``
        }
            placement={"end"}
            backDrop={true}
            scrolling={false}
            preventEscapeKey={false}
            offId={"newBook"}
            canvasTitle={"New Book"}
            offcanvaswidth={550}
            &gt;
        <rdscompbook nameprop="{&quot;&quot;}" typeprop="{&quot;&quot;}" publishdateprop="{&quot;&quot;}" priceprop="{&quot;&quot;}" onsavehandler="{onNewCreate}" offcanvastype="{&quot;create&quot;}" typeenumitems="{TypeEnum}">`</rdscompbook>`
        `</rdsoffcanvas>`

Agora ⁇  esta função dentro do componente do livro

       const onNewCreate = (datafromcomponent: any) =&gt; {
            let TypeIndex = datafromcomponent.data.Type
            const data = {
            name: datafromcomponent.data.Name,
            type:TypeIndex,
            publishDate: datafromcomponent.data.PublishDate.toISOString().substring(0, 19),
            price: datafromcomponent.data.Price
        }
        dispatch(postBooksRequest({requestBody:data}) as any).then((res: any) =&gt; {
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
                    }).catch((error: any) =&gt; {
                    setAlert({
                                ...Alert,
                                show: true,
                                message: "Something went wrong",
                                color: "danger",
                            });
                console.error(error);
            });
        };

### actualizando um novo livro -
Defina as ações para Editar na forma de um array como ⁇  abaixo

        const actions = [{ id: "edit", displayName: t("Edit"), offId: "BookEdit"}]

Atualizar a ⁇  usando ações usadas na ⁇  de dados. ⁇  de dados atualizadas vai parecer

    &lt;RdsCompDatatable classes="table__userTable" tableHeaders={tableHeaders} pagination={true}
        tableData={Data} actions={actions}onActionSelection={onActionSelection} recordsPerPage={5}  recordsPerPageSelectListOption={true}&gt;`&lt;/RdsCompDatatable &gt;`

Adicionar o seguinte código de corte dentro do arquivo de Slice e ⁇  casos de construtor ⁇  ao fetchbook

        export const putBooksRequest = createAsyncThunk(
        'book/putBooksRequest',
        async   ({
                    id,
                    requestBody,
                }:{
                    id: string,
                    requestBody?: DemoSuite2_Books_BookUpdateDto,
                }) =&gt; {
                    const response = await BookService.putBooks({
                    id,
                    requestBody,
                });
                    return response;
                }
        );

Adicionar estes casos de construtor dentro BookSlice extra ⁇

        builder.addCase(putBooksRequest.pending, (state) =&gt; {
            state.loading = true;
        });
            builder.addCase(putBooksRequest.fulfilled, (state, action) =&gt; {
            state.loading = false;
            state.error = "";
        });
            builder.addCase(putBooksRequest.rejected,(state, action)=&gt; {
            state.loading = false;
            state.error = action.error.message || "Something went wrong";
        });

Adicionar a função Editar em Book Page

      const onEdithandler = (datafromcomponent: any) =&gt; {
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
                .then((res: any) =&gt; {
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
            .catch((error: any) =&gt; {
                setAlert({
                ...Alert,
                show: true,
                message: "Something went wrong",
                color: "danger",
            });
                console.error(error);
            });
        };

Adicionar propriedade de RdsOffcanvas elemento abaixo RdsCompDatable

        <rdsoffcanvas placement="{&quot;end&quot;}" backdrop="{true}" scrolling="{false}" preventescapekey="{false}" offid="{&quot;BookEdit&quot;}" canvastitle="{&quot;Edit&quot;}" offcanvaswidth="{550}">
        &lt;&gt;
            <rdscompbook nameprop="{dataEmit.name}" typeprop="{dataEmit.type}" publishdateprop="{dataEmit.publishDate}" priceprop="{dataEmit.price}" offcanvastype="{&quot;update&quot;}" typeenumitems="{TypeEnum}" onsavehandler="{onEdithandler}">`</rdscompbook>`
        
        `</rdsoffcanvas>`

### excluindo um novo livro –
⁇  a função Editar em Book Page

    const actions = [{ id: "Delete", displayName: t("Delete"), modalId: "bookDel" }]
                                   ]

Agora adicionamos um arquivo de corte usado para Apagar a ⁇

       export const deleteBooksRequest = createAsyncThunk(
        'book/deleteBooksRequest',
        async   ({
                    id,
                }:{
                    id: string,
                }) =&gt; {
                    const response = await BookService.deleteBooks({
                    id,
                });                return response;
                }
        );

Adicionar estes casos de construtor dentro BookSlice extra ⁇

        builder.addCase(deleteBooksRequest.pending, (state) =&gt; {
            state.loading = true;
        });
            builder.addCase(deleteBooksRequest.fulfilled, (state, action) =&gt; {
            state.loading = false;
            state.error = "";
        });
            builder.addCase(deleteBooksRequest.rejected,(state, action)=&gt; {
            state.loading = false;
            state.error = action.error.message || "Something went wrong";
        });

Integramos um componente ⁇  RdsCompAlertPopup para ⁇  alerta durante a ⁇  de uma lista de livros

        <rdscompalertpopup alertid="{&quot;bookDel&quot;}" onsuccess="{onDeleteHandler}"></rdscompalertpopup>

Adicionar função de ⁇  em Book Page
