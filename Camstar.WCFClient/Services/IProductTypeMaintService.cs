// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IProductTypeMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IProductTypeMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ProductTypeMaint productTypeMaint,
      ProductTypeMaint_Parameters parameters,
      ProductTypeMaint_Request request,
      out ProductTypeMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      ProductTypeMaint productTypeMaint,
      ProductTypeMaint_Parameters parameters,
      ProductTypeMaint_Request request,
      out ProductTypeMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ProductTypeMaint productTypeMaint,
      ProductTypeMaint_Parameters parameters,
      ProductTypeMaint_Request request,
      out ProductTypeMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ProductTypeMaint productTypeMaint,
      ProductTypeMaint_Parameters parameters,
      ProductTypeMaint_Request request,
      out ProductTypeMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ProductTypeMaint productTypeMaint,
      ProductTypeMaint_LoadESigDetails_Parameters parameters,
      ProductTypeMaint_Request request,
      out ProductTypeMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ProductTypeMaint productTypeMaint,
      ProductTypeMaint_Parameters parameters,
      ProductTypeMaint_Request request,
      out ProductTypeMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      ProductTypeMaint productTypeMaint,
      ProductTypeMaint_Parameters parameters,
      ProductTypeMaint_Request request,
      out ProductTypeMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      ProductTypeMaint productTypeMaint,
      ProductTypeMaint_Parameters parameters,
      ProductTypeMaint_Request request,
      out ProductTypeMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      ProductTypeMaint productTypeMaint,
      ProductTypeMaint_Parameters parameters,
      ProductTypeMaint_Request request,
      out ProductTypeMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ProductTypeMaintMethod[] methods,
      ProductTypeMaint_Request request,
      out ProductTypeMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ProductTypeMaint productTypeMaint,
      ProductTypeMaint_Request request,
      out ProductTypeMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ProductTypeMaint productTypeMaint,
      ProductTypeMaint_Request request,
      out ProductTypeMaint_Result result);
  }
}
