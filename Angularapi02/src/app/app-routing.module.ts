import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { TableComponent } from './component/table/table.component';
import { CharComponent } from './component/char/char.component';
import { LineComponent } from './component/char/line/line.component';
import { PieComponent } from './component/char/pie/pie.component';
import { InsertComponent } from './component/table/insert/insert.component';
import { SelectComponent } from './component/table/select/select.component';
const routes: Routes = [
  {
    path: 'table', component: TableComponent,
    children: [
      { path: 'insert', component: InsertComponent },
      { path: 'select', component: SelectComponent },
      { path: '**', redirectTo: 'select' },
    ]
  }, {
    path: 'char', component: CharComponent,
    children: [
      { path: 'line', component: LineComponent },
      { path: 'pie', component: PieComponent },
      { path: '**', redirectTo: 'line' },
    ]
  },
  { path: '**', redirectTo: 'table' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
