// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IMasterDataCatalogMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IMasterDataCatalogMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      MasterDataCatalogMaint masterDataCatalogMaint,
      MasterDataCatalogMaint_Parameters parameters,
      MasterDataCatalogMaint_Request request,
      out MasterDataCatalogMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      MasterDataCatalogMaint masterDataCatalogMaint,
      MasterDataCatalogMaint_Parameters parameters,
      MasterDataCatalogMaint_Request request,
      out MasterDataCatalogMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      MasterDataCatalogMaint masterDataCatalogMaint,
      MasterDataCatalogMaint_Parameters parameters,
      MasterDataCatalogMaint_Request request,
      out MasterDataCatalogMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      MasterDataCatalogMaint masterDataCatalogMaint,
      MasterDataCatalogMaint_Parameters parameters,
      MasterDataCatalogMaint_Request request,
      out MasterDataCatalogMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      MasterDataCatalogMaint masterDataCatalogMaint,
      MasterDataCatalogMaint_LoadESigDetails_Parameters parameters,
      MasterDataCatalogMaint_Request request,
      out MasterDataCatalogMaint_Result result);

    [OperationContract]
    ResultStatus LoadMasterDataCatalogDtl(
      UserProfile userProfile,
      MasterDataCatalogMaint masterDataCatalogMaint,
      MasterDataCatalogMaint_Parameters parameters,
      MasterDataCatalogMaint_Request request,
      out MasterDataCatalogMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      MasterDataCatalogMaint masterDataCatalogMaint,
      MasterDataCatalogMaint_Parameters parameters,
      MasterDataCatalogMaint_Request request,
      out MasterDataCatalogMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      MasterDataCatalogMaint masterDataCatalogMaint,
      MasterDataCatalogMaint_Parameters parameters,
      MasterDataCatalogMaint_Request request,
      out MasterDataCatalogMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      MasterDataCatalogMaint masterDataCatalogMaint,
      MasterDataCatalogMaint_Parameters parameters,
      MasterDataCatalogMaint_Request request,
      out MasterDataCatalogMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      MasterDataCatalogMaint masterDataCatalogMaint,
      MasterDataCatalogMaint_Parameters parameters,
      MasterDataCatalogMaint_Request request,
      out MasterDataCatalogMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      MasterDataCatalogMaintMethod[] methods,
      MasterDataCatalogMaint_Request request,
      out MasterDataCatalogMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      MasterDataCatalogMaint masterDataCatalogMaint,
      MasterDataCatalogMaint_Request request,
      out MasterDataCatalogMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      MasterDataCatalogMaint masterDataCatalogMaint,
      MasterDataCatalogMaint_Request request,
      out MasterDataCatalogMaint_Result result);
  }
}
