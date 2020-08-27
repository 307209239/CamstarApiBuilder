// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IHoldsService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IHoldsService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      Holds holds,
      Holds_Parameters parameters,
      Holds_Request request,
      out Holds_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      Holds holds,
      Holds_Parameters parameters,
      Holds_Request request,
      out Holds_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      Holds holds,
      Holds_Parameters parameters,
      Holds_Request request,
      out Holds_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      Holds holds,
      Holds_Parameters parameters,
      Holds_Request request,
      out Holds_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      Holds holds,
      Holds_Parameters parameters,
      Holds_Request request,
      out Holds_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      Holds holds,
      Holds_LoadESigDetails_Parameters parameters,
      Holds_Request request,
      out Holds_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      Holds holds,
      Holds_Parameters parameters,
      Holds_Request request,
      out Holds_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      Holds holds,
      Holds_Parameters parameters,
      Holds_Request request,
      out Holds_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      HoldsMethod[] methods,
      Holds_Request request,
      out Holds_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      Holds holds,
      Holds_Request request,
      out Holds_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      Holds holds,
      Holds_Request request,
      out Holds_Result result);
  }
}
