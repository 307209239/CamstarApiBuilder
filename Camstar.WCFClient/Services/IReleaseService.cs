// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IReleaseService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IReleaseService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      Release release,
      Release_Parameters parameters,
      Release_Request request,
      out Release_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      Release release,
      Release_Parameters parameters,
      Release_Request request,
      out Release_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      Release release,
      Release_Parameters parameters,
      Release_Request request,
      out Release_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      Release release,
      Release_Parameters parameters,
      Release_Request request,
      out Release_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      Release release,
      Release_Parameters parameters,
      Release_Request request,
      out Release_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      Release release,
      Release_LoadESigDetails_Parameters parameters,
      Release_Request request,
      out Release_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      Release release,
      Release_Parameters parameters,
      Release_Request request,
      out Release_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      Release release,
      Release_Parameters parameters,
      Release_Request request,
      out Release_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ReleaseMethod[] methods,
      Release_Request request,
      out Release_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      Release release,
      Release_Request request,
      out Release_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      Release release,
      Release_Request request,
      out Release_Result result);
  }
}
