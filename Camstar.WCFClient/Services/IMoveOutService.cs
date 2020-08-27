// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IMoveOutService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IMoveOutService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      MoveOut moveOut,
      MoveOut_Parameters parameters,
      MoveOut_Request request,
      out MoveOut_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      MoveOut moveOut,
      MoveOut_Parameters parameters,
      MoveOut_Request request,
      out MoveOut_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      MoveOut moveOut,
      MoveOut_Parameters parameters,
      MoveOut_Request request,
      out MoveOut_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      MoveOut moveOut,
      MoveOut_Parameters parameters,
      MoveOut_Request request,
      out MoveOut_Result result);

    [OperationContract]
    ResultStatus InitializeService(
      UserProfile userProfile,
      MoveOut moveOut,
      MoveOut_Parameters parameters,
      MoveOut_Request request,
      out MoveOut_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      MoveOut moveOut,
      MoveOut_Parameters parameters,
      MoveOut_Request request,
      out MoveOut_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      MoveOut moveOut,
      MoveOut_LoadESigDetails_Parameters parameters,
      MoveOut_Request request,
      out MoveOut_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      MoveOut moveOut,
      MoveOut_Parameters parameters,
      MoveOut_Request request,
      out MoveOut_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      MoveOut moveOut,
      MoveOut_Parameters parameters,
      MoveOut_Request request,
      out MoveOut_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      MoveOutMethod[] methods,
      MoveOut_Request request,
      out MoveOut_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      MoveOut moveOut,
      MoveOut_Request request,
      out MoveOut_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      MoveOut moveOut,
      MoveOut_Request request,
      out MoveOut_Result result);
  }
}
