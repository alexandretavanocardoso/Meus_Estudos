
===> SERVICE

create(product: Product): Observable<Product> {
	return this.http.post<Product>(this.baseUrl, product).pipe(
	  map((obj) => obj),
	  catchError((e) => this.errorHandler(e))
	);
}

read(): Observable<Product[]> {
	return this.http.get<Product[]>(this.baseUrl).pipe(
	  map((obj) => obj),
	  catchError((e) => this.errorHandler(e))
	);
}

readById(id: number): Observable<Product> {
	const url = `${this.baseUrl}/${id}`;
	return this.http.get<Product>(url).pipe(
	  map((obj) => obj),
	  catchError((e) => this.errorHandler(e))
	);
}

update(product: Product): Observable<Product> {
	const url = `${this.baseUrl}/${product.id}`;
	return this.http.put<Product>(url, product).pipe(
	  map((obj) => obj),
	  catchError((e) => this.errorHandler(e))
	);
}

delete(id: number): Observable<Product> {
	const url = `${this.baseUrl}/${id}`;
	return this.http.delete<Product>(url).pipe(
	  map((obj) => obj),
	  catchError((e) => this.errorHandler(e))
	);
}


===>> PAGES

================> CREATE

  createProduct(): void {
    this.productService.create(this.product).subscribe(() => {
      this.productService.showMessage('Produto criado!')
      this.router.navigate(['/products'])
    })
  }

================> DELETE

  deleteProduct(): void {
    this.productService.delete(this.product.id).subscribe(() => {
      this.productService.showMessage("Produto excluido com sucesso!");
      this.router.navigate(["/products"]);
    });
  }

================> UPDATE

  updateProduct(): void {
    this.productService.update(this.product).subscribe(() => {
      this.productService.showMessage("Produto atualizado com sucesso!");
      this.router.navigate(["/products"]);
    });
  }

================> READ

  ngOnInit(): void {
    this.productService.read().subscribe(products => {
      this.products = products
    })
  }

================> READBYID

  ngOnInit(): void {
    const id = +this.route.snapshot.paramMap.get('id');
    this.productService.readById(id).subscribe((product) => {
      this.product = product;
    });
  }