// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IActionMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IActionMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ActionMaint actionMaint,
      ActionMaint_Parameters parameters,
      ActionMaint_Request request,
      out ActionMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      ActionMaint actionMaint,
      ActionMaint_Parameters parameters,
      ActionMaint_Request request,
      out ActionMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ActionMaint actionMaint,
      ActionMaint_Parameters parameters,
      ActionMaint_Request request,
      out ActionMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ActionMaint actionMaint,
      ActionMaint_Parameters parameters,
      ActionMaint_Request request,
      out ActionMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ActionMaint actionMaint,
      ActionMaint_LoadESigDetails_Parameters parameters,
      ActionMaint_Request request,
      out ActionMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ActionMaint actionMaint,
      ActionMaint_Parameters parameters,
      ActionMaint_Request request,
      out ActionMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      ActionMaint actionMaint,
      ActionMaint_Parameters parameters,
      ActionMaint_Request request,
      out ActionMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      ActionMaint actionMaint,
      ActionMaint_Parameters parameters,
      ActionMaint_Request request,
      out ActionMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      ActionMaint actionMaint,
      ActionMaint_Parameters parameters,
      ActionMaint_Request request,
      out ActionMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ActionMaintMethod[] methods,
      ActionMaint_Request request,
      out ActionMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ActionMaint actionMaint,
      ActionMaint_Request request,
      out ActionMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ActionMaint actionMaint,
      ActionMaint_Request request,
      out ActionMaint_Result result);
  }
}
