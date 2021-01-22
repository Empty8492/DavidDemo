import { Component, OnInit } from '@angular/core';
import * as $ from 'jquery';
import *as Highcharts from 'highcharts';
@Component({
  selector: 'app-pie',
  templateUrl: './pie.component.html',
  styleUrls: ['./pie.component.css']
})
export class PieComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
    $.ajax({
      url: "https://localhost:44371/api/Users/GetpieHighcharts",
      type: "get",
      success: function (data) {
          //console.log(data);
          var jsondata = JSON.parse(data);
          console.log(jsondata);
          var options2 = {

            chart: {
              type: 'pie'
            },
            title: {
              text: '月份总和'
            },
            tooltip: {
              pointFormat: '{series.name}: <b>{point.percentage:.1f}%</b>'
            },
            series: [{
              name: 'Brands',
              data:jsondata
            }]
          };
          Highcharts.chart('container2', options2);
      }
  });
  
}

}
