// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IThruputService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IThruputService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      Thruput thruput,
      Thruput_Parameters parameters,
      Thruput_Request request,
      out Thruput_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      Thruput thruput,
      Thruput_Parameters parameters,
      Thruput_Request request,
      out Thruput_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      Thruput thruput,
      Thruput_Parameters parameters,
      Thruput_Request request,
      out Thruput_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      Thruput thruput,
      Thruput_Parameters parameters,
      Thruput_Request request,
      out Thruput_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      Thruput thruput,
      Thruput_Parameters parameters,
      Thruput_Request request,
      out Thruput_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      Thruput thruput,
      Thruput_LoadESigDetails_Parameters parameters,
      Thruput_Request request,
      out Thruput_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      Thruput thruput,
      Thruput_Parameters parameters,
      Thruput_Request request,
      out Thruput_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      Thruput thruput,
      Thruput_Parameters parameters,
      Thruput_Request request,
      out Thruput_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ThruputMethod[] methods,
      Thruput_Request request,
      out Thruput_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      Thruput thruput,
      Thruput_Request request,
      out Thruput_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      Thruput thruput,
      Thruput_Request request,
      out Thruput_Result result);
  }
}
