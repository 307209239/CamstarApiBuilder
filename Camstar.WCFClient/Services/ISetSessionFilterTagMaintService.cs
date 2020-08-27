// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ISetSessionFilterTagMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ISetSessionFilterTagMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      SetSessionFilterTagMaint setSessionFilterTagMaint,
      SetSessionFilterTagMaint_Parameters parameters,
      SetSessionFilterTagMaint_Request request,
      out SetSessionFilterTagMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      SetSessionFilterTagMaint setSessionFilterTagMaint,
      SetSessionFilterTagMaint_Parameters parameters,
      SetSessionFilterTagMaint_Request request,
      out SetSessionFilterTagMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      SetSessionFilterTagMaint setSessionFilterTagMaint,
      SetSessionFilterTagMaint_Parameters parameters,
      SetSessionFilterTagMaint_Request request,
      out SetSessionFilterTagMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      SetSessionFilterTagMaint setSessionFilterTagMaint,
      SetSessionFilterTagMaint_Parameters parameters,
      SetSessionFilterTagMaint_Request request,
      out SetSessionFilterTagMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      SetSessionFilterTagMaint setSessionFilterTagMaint,
      SetSessionFilterTagMaint_LoadESigDetails_Parameters parameters,
      SetSessionFilterTagMaint_Request request,
      out SetSessionFilterTagMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      SetSessionFilterTagMaint setSessionFilterTagMaint,
      SetSessionFilterTagMaint_Parameters parameters,
      SetSessionFilterTagMaint_Request request,
      out SetSessionFilterTagMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      SetSessionFilterTagMaint setSessionFilterTagMaint,
      SetSessionFilterTagMaint_Parameters parameters,
      SetSessionFilterTagMaint_Request request,
      out SetSessionFilterTagMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      SetSessionFilterTagMaint setSessionFilterTagMaint,
      SetSessionFilterTagMaint_Parameters parameters,
      SetSessionFilterTagMaint_Request request,
      out SetSessionFilterTagMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      SetSessionFilterTagMaint setSessionFilterTagMaint,
      SetSessionFilterTagMaint_Parameters parameters,
      SetSessionFilterTagMaint_Request request,
      out SetSessionFilterTagMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      SetSessionFilterTagMaintMethod[] methods,
      SetSessionFilterTagMaint_Request request,
      out SetSessionFilterTagMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      SetSessionFilterTagMaint setSessionFilterTagMaint,
      SetSessionFilterTagMaint_Request request,
      out SetSessionFilterTagMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      SetSessionFilterTagMaint setSessionFilterTagMaint,
      SetSessionFilterTagMaint_Request request,
      out SetSessionFilterTagMaint_Result result);
  }
}
