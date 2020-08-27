// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IDetachSingleCPContentService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IDetachSingleCPContentService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      DetachSingleCPContent detachSingleCPContent,
      DetachSingleCPContent_Parameters parameters,
      DetachSingleCPContent_Request request,
      out DetachSingleCPContent_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      DetachSingleCPContent detachSingleCPContent,
      DetachSingleCPContent_Parameters parameters,
      DetachSingleCPContent_Request request,
      out DetachSingleCPContent_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      DetachSingleCPContent detachSingleCPContent,
      DetachSingleCPContent_Parameters parameters,
      DetachSingleCPContent_Request request,
      out DetachSingleCPContent_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      DetachSingleCPContent detachSingleCPContent,
      DetachSingleCPContent_Parameters parameters,
      DetachSingleCPContent_Request request,
      out DetachSingleCPContent_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      DetachSingleCPContent detachSingleCPContent,
      DetachSingleCPContent_Parameters parameters,
      DetachSingleCPContent_Request request,
      out DetachSingleCPContent_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      DetachSingleCPContent detachSingleCPContent,
      DetachSingleCPContent_LoadESigDetails_Parameters parameters,
      DetachSingleCPContent_Request request,
      out DetachSingleCPContent_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      DetachSingleCPContent detachSingleCPContent,
      DetachSingleCPContent_Parameters parameters,
      DetachSingleCPContent_Request request,
      out DetachSingleCPContent_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      DetachSingleCPContent detachSingleCPContent,
      DetachSingleCPContent_Parameters parameters,
      DetachSingleCPContent_Request request,
      out DetachSingleCPContent_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      DetachSingleCPContentMethod[] methods,
      DetachSingleCPContent_Request request,
      out DetachSingleCPContent_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      DetachSingleCPContent detachSingleCPContent,
      DetachSingleCPContent_Request request,
      out DetachSingleCPContent_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      DetachSingleCPContent detachSingleCPContent,
      DetachSingleCPContent_Request request,
      out DetachSingleCPContent_Result result);
  }
}
