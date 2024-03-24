export interface ICatalog {
  Id: string;
  CreatorId: string;
  CatalogName: string;
  CreationDate: string;
}

export interface ICreateCatalogDto {
  CreatorId: string;
  CatalogName: string;
}

export interface IEmissionFactor {
  Id: string;
  CatalogId: string;
  CreatorId: string;
  EmissionFactorTitle: string;
  EmissionFactorValue: string;
  EffectiveStartDate: string;
  EffectiveEndDate: string;
  CreationDate: string;
}

export interface ICreateEmissionFactorDto {
  CatalogId: string;
  CreatorId: string;
  EmissionFactorTitle: string;
  EmissionFactorValue: string;
}

export interface IEmissionPoint{
  Id: string;
  EmissionSourceUnitId : string;
  CreatorId : string;
  PointName : string;
  PointDescription : string;
  PointIcon : string;
  CreationDate : string;
}

export interface ICreateEmissionPointDto{
  EmissionSourceUnitId : string;
  CreatorId : string;
  PointName : string;
  PointDescription : string;
  PointIcon : string;
}

export interface IEmissionSource{
  Id: string;
  CreatorId: string;
  SourceName: string;
  SourceIcon: string;
  CreationDate: string;
}

export interface IcreateEmissionSourceDto{

  CreatorId: string;
  SourceName: string;
  SourceIcon: string;
  
}

export interface IEmissionSourcesUnit{
  Id: string;
  CreatorId: string;
  UnitTitle: string;
  UnitSymbol: string;
  CreationDate: string;
} 

export interface ICreateEmissionSourcesUnit{

  CreatorId: string;
  UnitTitle: string;
  UnitSymbol: string;

}

