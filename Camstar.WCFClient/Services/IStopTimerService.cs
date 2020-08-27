// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IStopTimerService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IStopTimerService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      Camstar.WCF.ObjectStack.StopTimer stopTimer,
      StopTimer_Parameters parameters,
      StopTimer_Request request,
      out StopTimer_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      Camstar.WCF.ObjectStack.StopTimer stopTimer,
      StopTimer_Parameters parameters,
      StopTimer_Request request,
      out StopTimer_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      Camstar.WCF.ObjectStack.StopTimer stopTimer,
      StopTimer_Parameters parameters,
      StopTimer_Request request,
      out StopTimer_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      Camstar.WCF.ObjectStack.StopTimer stopTimer,
      StopTimer_Parameters parameters,
      StopTimer_Request request,
      out StopTimer_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      Camstar.WCF.ObjectStack.StopTimer stopTimer,
      StopTimer_Parameters parameters,
      StopTimer_Request request,
      out StopTimer_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      Camstar.WCF.ObjectStack.StopTimer stopTimer,
      StopTimer_LoadESigDetails_Parameters parameters,
      StopTimer_Request request,
      out StopTimer_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      Camstar.WCF.ObjectStack.StopTimer stopTimer,
      StopTimer_Parameters parameters,
      StopTimer_Request request,
      out StopTimer_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      Camstar.WCF.ObjectStack.StopTimer stopTimer,
      StopTimer_Parameters parameters,
      StopTimer_Request request,
      out StopTimer_Result result);

    [OperationContract]
    ResultStatus StopTimer(
      UserProfile userProfile,
      Camstar.WCF.ObjectStack.StopTimer stopTimer,
      StopTimer_StopTimer_Parameters parameters,
      StopTimer_Request request,
      out StopTimer_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      StopTimerMethod[] methods,
      StopTimer_Request request,
      out StopTimer_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      Camstar.WCF.ObjectStack.StopTimer stopTimer,
      StopTimer_Request request,
      out StopTimer_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      Camstar.WCF.ObjectStack.StopTimer stopTimer,
      StopTimer_Request request,
      out StopTimer_Result result);
  }
}
