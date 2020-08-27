// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IOpenService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IOpenService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      Open open,
      Open_Parameters parameters,
      Open_Request request,
      out Open_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      Open open,
      Open_Parameters parameters,
      Open_Request request,
      out Open_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      Open open,
      Open_Parameters parameters,
      Open_Request request,
      out Open_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      Open open,
      Open_Parameters parameters,
      Open_Request request,
      out Open_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      Open open,
      Open_Parameters parameters,
      Open_Request request,
      out Open_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      Open open,
      Open_LoadESigDetails_Parameters parameters,
      Open_Request request,
      out Open_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      Open open,
      Open_Parameters parameters,
      Open_Request request,
      out Open_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      Open open,
      Open_Parameters parameters,
      Open_Request request,
      out Open_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      OpenMethod[] methods,
      Open_Request request,
      out Open_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      Open open,
      Open_Request request,
      out Open_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      Open open,
      Open_Request request,
      out Open_Result result);
  }
}
