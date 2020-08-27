// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IMasterRecipeMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IMasterRecipeMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      MasterRecipeMaint masterRecipeMaint,
      MasterRecipeMaint_Parameters parameters,
      MasterRecipeMaint_Request request,
      out MasterRecipeMaint_Result result);

    [OperationContract]
    ResultStatus DeleteAllRevisions(
      UserProfile userProfile,
      MasterRecipeMaint masterRecipeMaint,
      MasterRecipeMaint_Parameters parameters,
      MasterRecipeMaint_Request request,
      out MasterRecipeMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      MasterRecipeMaint masterRecipeMaint,
      MasterRecipeMaint_Parameters parameters,
      MasterRecipeMaint_Request request,
      out MasterRecipeMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      MasterRecipeMaint masterRecipeMaint,
      MasterRecipeMaint_Parameters parameters,
      MasterRecipeMaint_Request request,
      out MasterRecipeMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      MasterRecipeMaint masterRecipeMaint,
      MasterRecipeMaint_Parameters parameters,
      MasterRecipeMaint_Request request,
      out MasterRecipeMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      MasterRecipeMaint masterRecipeMaint,
      MasterRecipeMaint_LoadESigDetails_Parameters parameters,
      MasterRecipeMaint_Request request,
      out MasterRecipeMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      MasterRecipeMaint masterRecipeMaint,
      MasterRecipeMaint_Parameters parameters,
      MasterRecipeMaint_Request request,
      out MasterRecipeMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      MasterRecipeMaint masterRecipeMaint,
      MasterRecipeMaint_Parameters parameters,
      MasterRecipeMaint_Request request,
      out MasterRecipeMaint_Result result);

    [OperationContract]
    ResultStatus NewRev(
      UserProfile userProfile,
      MasterRecipeMaint masterRecipeMaint,
      MasterRecipeMaint_Parameters parameters,
      MasterRecipeMaint_Request request,
      out MasterRecipeMaint_Result result);

    [OperationContract]
    ResultStatus NewRevCopy(
      UserProfile userProfile,
      MasterRecipeMaint masterRecipeMaint,
      MasterRecipeMaint_Parameters parameters,
      MasterRecipeMaint_Request request,
      out MasterRecipeMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      MasterRecipeMaint masterRecipeMaint,
      MasterRecipeMaint_Parameters parameters,
      MasterRecipeMaint_Request request,
      out MasterRecipeMaint_Result result);

    [OperationContract]
    ResultStatus SaveAsRev(
      UserProfile userProfile,
      MasterRecipeMaint masterRecipeMaint,
      MasterRecipeMaint_Parameters parameters,
      MasterRecipeMaint_Request request,
      out MasterRecipeMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      MasterRecipeMaint masterRecipeMaint,
      MasterRecipeMaint_Parameters parameters,
      MasterRecipeMaint_Request request,
      out MasterRecipeMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      MasterRecipeMaintMethod[] methods,
      MasterRecipeMaint_Request request,
      out MasterRecipeMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      MasterRecipeMaint masterRecipeMaint,
      MasterRecipeMaint_Request request,
      out MasterRecipeMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      MasterRecipeMaint masterRecipeMaint,
      MasterRecipeMaint_Request request,
      out MasterRecipeMaint_Result result);
  }
}
