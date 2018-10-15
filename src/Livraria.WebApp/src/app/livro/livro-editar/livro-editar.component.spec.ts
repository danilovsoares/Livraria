import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { LivroEditarComponent } from './livro-editar.component';

describe('LivroEditarComponent', () => {
  let component: LivroEditarComponent;
  let fixture: ComponentFixture<LivroEditarComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ LivroEditarComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LivroEditarComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
