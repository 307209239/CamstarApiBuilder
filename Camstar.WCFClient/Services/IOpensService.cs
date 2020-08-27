// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IOpensService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IOpensService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      Opens opens,
      Opens_Parameters parameters,
      Opens_Request request,
      out Opens_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      Opens opens,
      Opens_Parameters parameters,
      Opens_Request request,
      out Opens_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      Opens opens,
      Opens_Parameters parameters,
      Opens_Request request,
      out Opens_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      Opens opens,
      Opens_Parameters parameters,
      Opens_Request request,
      out Opens_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      Opens opens,
      Opens_Parameters parameters,
      Opens_Request request,
      out Opens_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      Opens opens,
      Opens_LoadESigDetails_Parameters parameters,
      Opens_Request request,
      out Opens_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      Opens opens,
      Opens_Parameters parameters,
      Opens_Request request,
      out Opens_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      Opens opens,
      Opens_Parameters parameters,
      Opens_Request request,
      out Opens_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      OpensMethod[] methods,
      Opens_Request request,
      out Opens_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      Opens opens,
      Opens_Request request,
      out Opens_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      Opens opens,
      Opens_Request request,
      out Opens_Result result);
  }
}
