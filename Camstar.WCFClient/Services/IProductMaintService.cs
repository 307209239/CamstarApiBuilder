// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IProductMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IProductMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ProductMaint productMaint,
      ProductMaint_Parameters parameters,
      ProductMaint_Request request,
      out ProductMaint_Result result);

    [OperationContract]
    ResultStatus DeleteAllRevisions(
      UserProfile userProfile,
      ProductMaint productMaint,
      ProductMaint_Parameters parameters,
      ProductMaint_Request request,
      out ProductMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      ProductMaint productMaint,
      ProductMaint_Parameters parameters,
      ProductMaint_Request request,
      out ProductMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ProductMaint productMaint,
      ProductMaint_Parameters parameters,
      ProductMaint_Request request,
      out ProductMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ProductMaint productMaint,
      ProductMaint_Parameters parameters,
      ProductMaint_Request request,
      out ProductMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ProductMaint productMaint,
      ProductMaint_LoadESigDetails_Parameters parameters,
      ProductMaint_Request request,
      out ProductMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ProductMaint productMaint,
      ProductMaint_Parameters parameters,
      ProductMaint_Request request,
      out ProductMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      ProductMaint productMaint,
      ProductMaint_Parameters parameters,
      ProductMaint_Request request,
      out ProductMaint_Result result);

    [OperationContract]
    ResultStatus NewRev(
      UserProfile userProfile,
      ProductMaint productMaint,
      ProductMaint_Parameters parameters,
      ProductMaint_Request request,
      out ProductMaint_Result result);

    [OperationContract]
    ResultStatus NewRevCopy(
      UserProfile userProfile,
      ProductMaint productMaint,
      ProductMaint_Parameters parameters,
      ProductMaint_Request request,
      out ProductMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      ProductMaint productMaint,
      ProductMaint_Parameters parameters,
      ProductMaint_Request request,
      out ProductMaint_Result result);

    [OperationContract]
    ResultStatus SaveAsRev(
      UserProfile userProfile,
      ProductMaint productMaint,
      ProductMaint_Parameters parameters,
      ProductMaint_Request request,
      out ProductMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      ProductMaint productMaint,
      ProductMaint_Parameters parameters,
      ProductMaint_Request request,
      out ProductMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ProductMaintMethod[] methods,
      ProductMaint_Request request,
      out ProductMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ProductMaint productMaint,
      ProductMaint_Request request,
      out ProductMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ProductMaint productMaint,
      ProductMaint_Request request,
      out ProductMaint_Result result);
  }
}
