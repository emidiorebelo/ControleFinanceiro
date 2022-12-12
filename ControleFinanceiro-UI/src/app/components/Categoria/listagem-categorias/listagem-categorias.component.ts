import { Component, Inject, OnInit } from '@angular/core';
import { CategoriasService } from 'src/app/services/categorias.service';
import { MatTableDataSource } from '@angular/material/table';
import { MAT_DIALOG_DATA, MatDialog } from '@angular/material/dialog';

@Component({
  selector: 'app-listagem-categorias',
  templateUrl: './listagem-categorias.component.html',
  styleUrls: ['./listagem-categorias.component.css'],
})
export class ListagemCategoriasComponent implements OnInit {

	categorias = new MatTableDataSource<any>();
	displayedColumns: string[];

  constructor(private categoriasService: CategoriasService,
		private dialog: MatDialog) { }

  ngOnInit(): void {
		this.categoriasService.PegarTodos().subscribe(resultado => {
			this.categorias.data = resultado;
			console.log(resultado)
		})

		this.displayedColumns = this.ExibirColunas();
  }

	ExibirColunas(): string[]{
		return ['nome', 'icone', 'tipo', 'acoes']
	}

	AbrirDialog(categoriaId, nome): void{
		this.dialog.open(DialogExclusaoCategoriasComponent,
			{
				data: {
					categoriaId: categoriaId,
					nome: nome,
				},
			})
			.afterClosed().subscribe(resultado => {
				if(resultado === true) {
					this.categoriasService.PegarTodos().subscribe((dados) => {
						this.categorias.data = dados;
					});
				}
			})
	}
}
@Component({
	selector: 'app-dialog-exclusao-categorias',
	templateUrl: 'dialog-exclusao-categorias',
})

export class DialogExclusaoCategoriasComponent{
	constructor(@Inject(MAT_DIALOG_DATA) public dados:any,
	private categoriasService: CategoriasService){}

	ExcluiCategoria(categoriaId): void {
		this.categoriasService.ExcluiCategoria(categoriaId).subscribe(resultado =>{

		});
	}
}
