// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IComponentReplaceService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IComponentReplaceService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      ComponentReplace componentReplace,
      ComponentReplace_Parameters parameters,
      ComponentReplace_Request request,
      out ComponentReplace_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      ComponentReplace componentReplace,
      ComponentReplace_Parameters parameters,
      ComponentReplace_Request request,
      out ComponentReplace_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      ComponentReplace componentReplace,
      ComponentReplace_Parameters parameters,
      ComponentReplace_Request request,
      out ComponentReplace_Result result);

    [OperationContract]
    ResultStatus GetRemovalDetails(
      UserProfile userProfile,
      ComponentReplace componentReplace,
      ComponentReplace_Parameters parameters,
      ComponentReplace_Request request,
      out ComponentReplace_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ComponentReplace componentReplace,
      ComponentReplace_Parameters parameters,
      ComponentReplace_Request request,
      out ComponentReplace_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ComponentReplace componentReplace,
      ComponentReplace_Parameters parameters,
      ComponentReplace_Request request,
      out ComponentReplace_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ComponentReplace componentReplace,
      ComponentReplace_LoadESigDetails_Parameters parameters,
      ComponentReplace_Request request,
      out ComponentReplace_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      ComponentReplace componentReplace,
      ComponentReplace_Parameters parameters,
      ComponentReplace_Request request,
      out ComponentReplace_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      ComponentReplace componentReplace,
      ComponentReplace_Parameters parameters,
      ComponentReplace_Request request,
      out ComponentReplace_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ComponentReplaceMethod[] methods,
      ComponentReplace_Request request,
      out ComponentReplace_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ComponentReplace componentReplace,
      ComponentReplace_Request request,
      out ComponentReplace_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ComponentReplace componentReplace,
      ComponentReplace_Request request,
      out ComponentReplace_Result result);
  }
}
