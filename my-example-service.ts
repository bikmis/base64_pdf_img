import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';


@Injectable({
  providedIn: 'root'
})
export class MyExampleService {

  constructor(private httpClient: HttpClient) { }

  public GetUsers(){
    var t = new Date();
    console.log('Inside of GetUsers: '+t.getHours()+':'+t.getMinutes()+':'+t.getSeconds()+':'+t.getMilliseconds())
    return this.httpClient.get<any>('https://jsonplaceholder.typicode.com/users');
  }
  
  public GetImages(id: number){
    var t = new Date();
    console.log('Inside of GetImages: '+t.getHours()+':'+t.getMinutes()+':'+t.getSeconds()+':'+t.getMilliseconds())
    return this.httpClient.get<any>(`https://localhost:7282/api/Images/${id}`);
  }


}
