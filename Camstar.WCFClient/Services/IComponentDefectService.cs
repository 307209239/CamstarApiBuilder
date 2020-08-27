// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IComponentDefectService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IComponentDefectService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      ComponentDefect componentDefect,
      ComponentDefect_Parameters parameters,
      ComponentDefect_Request request,
      out ComponentDefect_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      ComponentDefect componentDefect,
      ComponentDefect_Parameters parameters,
      ComponentDefect_Request request,
      out ComponentDefect_Result result);

    [OperationContract]
    ResultStatus GetActuals(
      UserProfile userProfile,
      ComponentDefect componentDefect,
      ComponentDefect_Parameters parameters,
      ComponentDefect_Request request,
      out ComponentDefect_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      ComponentDefect componentDefect,
      ComponentDefect_Parameters parameters,
      ComponentDefect_Request request,
      out ComponentDefect_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ComponentDefect componentDefect,
      ComponentDefect_Parameters parameters,
      ComponentDefect_Request request,
      out ComponentDefect_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ComponentDefect componentDefect,
      ComponentDefect_Parameters parameters,
      ComponentDefect_Request request,
      out ComponentDefect_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ComponentDefect componentDefect,
      ComponentDefect_LoadESigDetails_Parameters parameters,
      ComponentDefect_Request request,
      out ComponentDefect_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      ComponentDefect componentDefect,
      ComponentDefect_Parameters parameters,
      ComponentDefect_Request request,
      out ComponentDefect_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      ComponentDefect componentDefect,
      ComponentDefect_Parameters parameters,
      ComponentDefect_Request request,
      out ComponentDefect_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ComponentDefectMethod[] methods,
      ComponentDefect_Request request,
      out ComponentDefect_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ComponentDefect componentDefect,
      ComponentDefect_Request request,
      out ComponentDefect_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ComponentDefect componentDefect,
      ComponentDefect_Request request,
      out ComponentDefect_Result result);
  }
}
