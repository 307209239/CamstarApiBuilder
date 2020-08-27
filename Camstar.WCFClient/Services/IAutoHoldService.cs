// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IAutoHoldService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IAutoHoldService
  {
    [OperationContract]
    ResultStatus ContainerTxn_Validations(
      UserProfile userProfile,
      AutoHold autoHold,
      AutoHold_Parameters parameters,
      AutoHold_Request request,
      out AutoHold_Result result);

    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      AutoHold autoHold,
      AutoHold_Parameters parameters,
      AutoHold_Request request,
      out AutoHold_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      AutoHold autoHold,
      AutoHold_Parameters parameters,
      AutoHold_Request request,
      out AutoHold_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      AutoHold autoHold,
      AutoHold_Parameters parameters,
      AutoHold_Request request,
      out AutoHold_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      AutoHold autoHold,
      AutoHold_Parameters parameters,
      AutoHold_Request request,
      out AutoHold_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      AutoHold autoHold,
      AutoHold_Parameters parameters,
      AutoHold_Request request,
      out AutoHold_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      AutoHold autoHold,
      AutoHold_LoadESigDetails_Parameters parameters,
      AutoHold_Request request,
      out AutoHold_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      AutoHold autoHold,
      AutoHold_Parameters parameters,
      AutoHold_Request request,
      out AutoHold_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      AutoHold autoHold,
      AutoHold_Parameters parameters,
      AutoHold_Request request,
      out AutoHold_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      AutoHoldMethod[] methods,
      AutoHold_Request request,
      out AutoHold_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      AutoHold autoHold,
      AutoHold_Request request,
      out AutoHold_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      AutoHold autoHold,
      AutoHold_Request request,
      out AutoHold_Result result);
  }
}
