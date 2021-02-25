/************
    TRY{} CATCH{} FINALLY{}
************/
tryCatch();

function tryCatch(){
    try {
        document.write("Sucesso");
    }
    catch (ex) {
        throw new Error(ex);
    }
    finally {
        document.write("Faça isso dando sucesso ou erro");
    }
}