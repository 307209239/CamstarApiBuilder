// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IProductFamilyMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IProductFamilyMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ProductFamilyMaint productFamilyMaint,
      ProductFamilyMaint_Parameters parameters,
      ProductFamilyMaint_Request request,
      out ProductFamilyMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      ProductFamilyMaint productFamilyMaint,
      ProductFamilyMaint_Parameters parameters,
      ProductFamilyMaint_Request request,
      out ProductFamilyMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ProductFamilyMaint productFamilyMaint,
      ProductFamilyMaint_Parameters parameters,
      ProductFamilyMaint_Request request,
      out ProductFamilyMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ProductFamilyMaint productFamilyMaint,
      ProductFamilyMaint_Parameters parameters,
      ProductFamilyMaint_Request request,
      out ProductFamilyMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ProductFamilyMaint productFamilyMaint,
      ProductFamilyMaint_LoadESigDetails_Parameters parameters,
      ProductFamilyMaint_Request request,
      out ProductFamilyMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ProductFamilyMaint productFamilyMaint,
      ProductFamilyMaint_Parameters parameters,
      ProductFamilyMaint_Request request,
      out ProductFamilyMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      ProductFamilyMaint productFamilyMaint,
      ProductFamilyMaint_Parameters parameters,
      ProductFamilyMaint_Request request,
      out ProductFamilyMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      ProductFamilyMaint productFamilyMaint,
      ProductFamilyMaint_Parameters parameters,
      ProductFamilyMaint_Request request,
      out ProductFamilyMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      ProductFamilyMaint productFamilyMaint,
      ProductFamilyMaint_Parameters parameters,
      ProductFamilyMaint_Request request,
      out ProductFamilyMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ProductFamilyMaintMethod[] methods,
      ProductFamilyMaint_Request request,
      out ProductFamilyMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ProductFamilyMaint productFamilyMaint,
      ProductFamilyMaint_Request request,
      out ProductFamilyMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ProductFamilyMaint productFamilyMaint,
      ProductFamilyMaint_Request request,
      out ProductFamilyMaint_Result result);
  }
}
