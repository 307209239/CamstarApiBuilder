// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ICloseService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ICloseService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      Close close,
      Close_Parameters parameters,
      Close_Request request,
      out Close_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      Close close,
      Close_Parameters parameters,
      Close_Request request,
      out Close_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      Close close,
      Close_Parameters parameters,
      Close_Request request,
      out Close_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      Close close,
      Close_Parameters parameters,
      Close_Request request,
      out Close_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      Close close,
      Close_Parameters parameters,
      Close_Request request,
      out Close_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      Close close,
      Close_LoadESigDetails_Parameters parameters,
      Close_Request request,
      out Close_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      Close close,
      Close_Parameters parameters,
      Close_Request request,
      out Close_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      Close close,
      Close_Parameters parameters,
      Close_Request request,
      out Close_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      CloseMethod[] methods,
      Close_Request request,
      out Close_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      Close close,
      Close_Request request,
      out Close_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      Close close,
      Close_Request request,
      out Close_Result result);
  }
}
