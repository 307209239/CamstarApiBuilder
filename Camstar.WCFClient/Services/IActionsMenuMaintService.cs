// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IActionsMenuMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IActionsMenuMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ActionsMenuMaint actionsMenuMaint,
      ActionsMenuMaint_Parameters parameters,
      ActionsMenuMaint_Request request,
      out ActionsMenuMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      ActionsMenuMaint actionsMenuMaint,
      ActionsMenuMaint_Parameters parameters,
      ActionsMenuMaint_Request request,
      out ActionsMenuMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ActionsMenuMaint actionsMenuMaint,
      ActionsMenuMaint_Parameters parameters,
      ActionsMenuMaint_Request request,
      out ActionsMenuMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ActionsMenuMaint actionsMenuMaint,
      ActionsMenuMaint_Parameters parameters,
      ActionsMenuMaint_Request request,
      out ActionsMenuMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ActionsMenuMaint actionsMenuMaint,
      ActionsMenuMaint_LoadESigDetails_Parameters parameters,
      ActionsMenuMaint_Request request,
      out ActionsMenuMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ActionsMenuMaint actionsMenuMaint,
      ActionsMenuMaint_Parameters parameters,
      ActionsMenuMaint_Request request,
      out ActionsMenuMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      ActionsMenuMaint actionsMenuMaint,
      ActionsMenuMaint_Parameters parameters,
      ActionsMenuMaint_Request request,
      out ActionsMenuMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      ActionsMenuMaint actionsMenuMaint,
      ActionsMenuMaint_Parameters parameters,
      ActionsMenuMaint_Request request,
      out ActionsMenuMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      ActionsMenuMaint actionsMenuMaint,
      ActionsMenuMaint_Parameters parameters,
      ActionsMenuMaint_Request request,
      out ActionsMenuMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ActionsMenuMaintMethod[] methods,
      ActionsMenuMaint_Request request,
      out ActionsMenuMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ActionsMenuMaint actionsMenuMaint,
      ActionsMenuMaint_Request request,
      out ActionsMenuMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ActionsMenuMaint actionsMenuMaint,
      ActionsMenuMaint_Request request,
      out ActionsMenuMaint_Result result);
  }
}
