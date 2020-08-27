// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IResolveCARService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IResolveCARService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      ResolveCAR resolveCAR,
      ResolveCAR_Parameters parameters,
      ResolveCAR_Request request,
      out ResolveCAR_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      ResolveCAR resolveCAR,
      ResolveCAR_Parameters parameters,
      ResolveCAR_Request request,
      out ResolveCAR_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      ResolveCAR resolveCAR,
      ResolveCAR_Parameters parameters,
      ResolveCAR_Request request,
      out ResolveCAR_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ResolveCAR resolveCAR,
      ResolveCAR_Parameters parameters,
      ResolveCAR_Request request,
      out ResolveCAR_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ResolveCAR resolveCAR,
      ResolveCAR_Parameters parameters,
      ResolveCAR_Request request,
      out ResolveCAR_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ResolveCAR resolveCAR,
      ResolveCAR_Parameters parameters,
      ResolveCAR_Request request,
      out ResolveCAR_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      ResolveCAR resolveCAR,
      ResolveCAR_Parameters parameters,
      ResolveCAR_Request request,
      out ResolveCAR_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      ResolveCAR resolveCAR,
      ResolveCAR_Parameters parameters,
      ResolveCAR_Request request,
      out ResolveCAR_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ResolveCARMethod[] methods,
      ResolveCAR_Request request,
      out ResolveCAR_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ResolveCAR resolveCAR,
      ResolveCAR_Request request,
      out ResolveCAR_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ResolveCAR resolveCAR,
      ResolveCAR_Request request,
      out ResolveCAR_Result result);
  }
}
