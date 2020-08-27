// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.AssignChangePkgContentService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class AssignChangePkgContentService : ChangeMgtTxnBase
  {
    public AssignChangePkgContentService(UserProfile userProfile)
    {
      this.Initialize(typeof (IAssignChangePkgContentService), userProfile);
    }

    public ResultStatus CreateParametricData(
      AssignChangePkgContent assignChangePkgContent,
      AssignChangePkgContent_Parameters parameters,
      AssignChangePkgContent_Request request,
      out AssignChangePkgContent_Result result)
    {
      result = (AssignChangePkgContent_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) assignChangePkgContent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignChangePkgContentService) this._Channel).CreateParametricData(this._UserProfile, assignChangePkgContent, parameters, request, out result) : this.AddMethod((Method) new AssignChangePkgContentMethod(assignChangePkgContent, AssignChangePkgContentMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) assignChangePkgContent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((AssignChangePkgContent) null, (AssignChangePkgContent_Parameters) null, (AssignChangePkgContent_Request) null, out AssignChangePkgContent_Result _);
    }

    public ResultStatus CreateParametricData(
      AssignChangePkgContent assignChangePkgContent)
    {
      return this.CreateParametricData(assignChangePkgContent, (AssignChangePkgContent_Parameters) null, (AssignChangePkgContent_Request) null, out AssignChangePkgContent_Result _);
    }

    public ResultStatus CreateParametricData(
      AssignChangePkgContent assignChangePkgContent,
      AssignChangePkgContent_Request request,
      out AssignChangePkgContent_Result result)
    {
      return this.CreateParametricData(assignChangePkgContent, (AssignChangePkgContent_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      AssignChangePkgContent assignChangePkgContent,
      AssignChangePkgContent_Parameters parameters,
      AssignChangePkgContent_Request request,
      out AssignChangePkgContent_Result result)
    {
      result = (AssignChangePkgContent_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) assignChangePkgContent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignChangePkgContentService) this._Channel).GetActions(this._UserProfile, assignChangePkgContent, parameters, request, out result) : this.AddMethod((Method) new AssignChangePkgContentMethod(assignChangePkgContent, AssignChangePkgContentMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) assignChangePkgContent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((AssignChangePkgContent) null, (AssignChangePkgContent_Parameters) null, (AssignChangePkgContent_Request) null, out AssignChangePkgContent_Result _);
    }

    public ResultStatus GetActions(AssignChangePkgContent assignChangePkgContent)
    {
      return this.GetActions(assignChangePkgContent, (AssignChangePkgContent_Parameters) null, (AssignChangePkgContent_Request) null, out AssignChangePkgContent_Result _);
    }

    public ResultStatus GetActions(
      AssignChangePkgContent assignChangePkgContent,
      AssignChangePkgContent_Request request,
      out AssignChangePkgContent_Result result)
    {
      return this.GetActions(assignChangePkgContent, (AssignChangePkgContent_Parameters) null, request, out result);
    }

    public ResultStatus GetCollaboratorEntry(
      AssignChangePkgContent assignChangePkgContent,
      AssignChangePkgContent_Parameters parameters,
      AssignChangePkgContent_Request request,
      out AssignChangePkgContent_Result result)
    {
      result = (AssignChangePkgContent_Result) null;
      this.OnBeforeCall(nameof (GetCollaboratorEntry), (DCObject) assignChangePkgContent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignChangePkgContentService) this._Channel).GetCollaboratorEntry(this._UserProfile, assignChangePkgContent, parameters, request, out result) : this.AddMethod((Method) new AssignChangePkgContentMethod(assignChangePkgContent, AssignChangePkgContentMethods.GetCollaboratorEntry, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetCollaboratorEntry), res, (DCObject) assignChangePkgContent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetCollaboratorEntry()
    {
      return this.GetCollaboratorEntry((AssignChangePkgContent) null, (AssignChangePkgContent_Parameters) null, (AssignChangePkgContent_Request) null, out AssignChangePkgContent_Result _);
    }

    public ResultStatus GetCollaboratorEntry(
      AssignChangePkgContent assignChangePkgContent)
    {
      return this.GetCollaboratorEntry(assignChangePkgContent, (AssignChangePkgContent_Parameters) null, (AssignChangePkgContent_Request) null, out AssignChangePkgContent_Result _);
    }

    public ResultStatus GetCollaboratorEntry(
      AssignChangePkgContent assignChangePkgContent,
      AssignChangePkgContent_Request request,
      out AssignChangePkgContent_Result result)
    {
      return this.GetCollaboratorEntry(assignChangePkgContent, (AssignChangePkgContent_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      AssignChangePkgContent assignChangePkgContent,
      AssignChangePkgContent_Parameters parameters,
      AssignChangePkgContent_Request request,
      out AssignChangePkgContent_Result result)
    {
      result = (AssignChangePkgContent_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) assignChangePkgContent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignChangePkgContentService) this._Channel).GetDataPoints(this._UserProfile, assignChangePkgContent, parameters, request, out result) : this.AddMethod((Method) new AssignChangePkgContentMethod(assignChangePkgContent, AssignChangePkgContentMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) assignChangePkgContent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((AssignChangePkgContent) null, (AssignChangePkgContent_Parameters) null, (AssignChangePkgContent_Request) null, out AssignChangePkgContent_Result _);
    }

    public ResultStatus GetDataPoints(AssignChangePkgContent assignChangePkgContent)
    {
      return this.GetDataPoints(assignChangePkgContent, (AssignChangePkgContent_Parameters) null, (AssignChangePkgContent_Request) null, out AssignChangePkgContent_Result _);
    }

    public ResultStatus GetDataPoints(
      AssignChangePkgContent assignChangePkgContent,
      AssignChangePkgContent_Request request,
      out AssignChangePkgContent_Result result)
    {
      return this.GetDataPoints(assignChangePkgContent, (AssignChangePkgContent_Parameters) null, request, out result);
    }

    public ResultStatus GetNextSheetLevel(
      AssignChangePkgContent assignChangePkgContent,
      AssignChangePkgContent_Parameters parameters,
      AssignChangePkgContent_Request request,
      out AssignChangePkgContent_Result result)
    {
      result = (AssignChangePkgContent_Result) null;
      this.OnBeforeCall(nameof (GetNextSheetLevel), (DCObject) assignChangePkgContent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignChangePkgContentService) this._Channel).GetNextSheetLevel(this._UserProfile, assignChangePkgContent, parameters, request, out result) : this.AddMethod((Method) new AssignChangePkgContentMethod(assignChangePkgContent, AssignChangePkgContentMethods.GetNextSheetLevel, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetNextSheetLevel), res, (DCObject) assignChangePkgContent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetNextSheetLevel()
    {
      return this.GetNextSheetLevel((AssignChangePkgContent) null, (AssignChangePkgContent_Parameters) null, (AssignChangePkgContent_Request) null, out AssignChangePkgContent_Result _);
    }

    public ResultStatus GetNextSheetLevel(AssignChangePkgContent assignChangePkgContent)
    {
      return this.GetNextSheetLevel(assignChangePkgContent, (AssignChangePkgContent_Parameters) null, (AssignChangePkgContent_Request) null, out AssignChangePkgContent_Result _);
    }

    public ResultStatus GetNextSheetLevel(
      AssignChangePkgContent assignChangePkgContent,
      AssignChangePkgContent_Request request,
      out AssignChangePkgContent_Result result)
    {
      return this.GetNextSheetLevel(assignChangePkgContent, (AssignChangePkgContent_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      AssignChangePkgContent assignChangePkgContent,
      AssignChangePkgContent_Parameters parameters,
      AssignChangePkgContent_Request request,
      out AssignChangePkgContent_Result result)
    {
      result = (AssignChangePkgContent_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) assignChangePkgContent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignChangePkgContentService) this._Channel).GetWIPMsgs(this._UserProfile, assignChangePkgContent, parameters, request, out result) : this.AddMethod((Method) new AssignChangePkgContentMethod(assignChangePkgContent, AssignChangePkgContentMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) assignChangePkgContent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((AssignChangePkgContent) null, (AssignChangePkgContent_Parameters) null, (AssignChangePkgContent_Request) null, out AssignChangePkgContent_Result _);
    }

    public ResultStatus GetWIPMsgs(AssignChangePkgContent assignChangePkgContent)
    {
      return this.GetWIPMsgs(assignChangePkgContent, (AssignChangePkgContent_Parameters) null, (AssignChangePkgContent_Request) null, out AssignChangePkgContent_Result _);
    }

    public ResultStatus GetWIPMsgs(
      AssignChangePkgContent assignChangePkgContent,
      AssignChangePkgContent_Request request,
      out AssignChangePkgContent_Result result)
    {
      return this.GetWIPMsgs(assignChangePkgContent, (AssignChangePkgContent_Parameters) null, request, out result);
    }

    public ResultStatus IsSheelLevelCompleted(
      AssignChangePkgContent assignChangePkgContent,
      AssignChangePkgContent_Parameters parameters,
      AssignChangePkgContent_Request request,
      out AssignChangePkgContent_Result result)
    {
      result = (AssignChangePkgContent_Result) null;
      this.OnBeforeCall(nameof (IsSheelLevelCompleted), (DCObject) assignChangePkgContent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignChangePkgContentService) this._Channel).IsSheelLevelCompleted(this._UserProfile, assignChangePkgContent, parameters, request, out result) : this.AddMethod((Method) new AssignChangePkgContentMethod(assignChangePkgContent, AssignChangePkgContentMethods.IsSheelLevelCompleted, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (IsSheelLevelCompleted), res, (DCObject) assignChangePkgContent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus IsSheelLevelCompleted()
    {
      return this.IsSheelLevelCompleted((AssignChangePkgContent) null, (AssignChangePkgContent_Parameters) null, (AssignChangePkgContent_Request) null, out AssignChangePkgContent_Result _);
    }

    public ResultStatus IsSheelLevelCompleted(
      AssignChangePkgContent assignChangePkgContent)
    {
      return this.IsSheelLevelCompleted(assignChangePkgContent, (AssignChangePkgContent_Parameters) null, (AssignChangePkgContent_Request) null, out AssignChangePkgContent_Result _);
    }

    public ResultStatus IsSheelLevelCompleted(
      AssignChangePkgContent assignChangePkgContent,
      AssignChangePkgContent_Request request,
      out AssignChangePkgContent_Result result)
    {
      return this.IsSheelLevelCompleted(assignChangePkgContent, (AssignChangePkgContent_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      AssignChangePkgContent assignChangePkgContent,
      AssignChangePkgContent_Parameters parameters,
      AssignChangePkgContent_Request request,
      out AssignChangePkgContent_Result result)
    {
      result = (AssignChangePkgContent_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) assignChangePkgContent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignChangePkgContentService) this._Channel).Load(this._UserProfile, assignChangePkgContent, parameters, request, out result) : this.AddMethod((Method) new AssignChangePkgContentMethod(assignChangePkgContent, AssignChangePkgContentMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) assignChangePkgContent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((AssignChangePkgContent) null, (AssignChangePkgContent_Parameters) null, (AssignChangePkgContent_Request) null, out AssignChangePkgContent_Result _);
    }

    public ResultStatus Load(AssignChangePkgContent assignChangePkgContent)
    {
      return this.Load(assignChangePkgContent, (AssignChangePkgContent_Parameters) null, (AssignChangePkgContent_Request) null, out AssignChangePkgContent_Result _);
    }

    public ResultStatus Load(
      AssignChangePkgContent assignChangePkgContent,
      AssignChangePkgContent_Request request,
      out AssignChangePkgContent_Result result)
    {
      return this.Load(assignChangePkgContent, (AssignChangePkgContent_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      AssignChangePkgContent assignChangePkgContent,
      AssignChangePkgContent_LoadESigDetails_Parameters parameters,
      AssignChangePkgContent_Request request,
      out AssignChangePkgContent_Result result)
    {
      result = (AssignChangePkgContent_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) assignChangePkgContent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignChangePkgContentService) this._Channel).LoadESigDetails(this._UserProfile, assignChangePkgContent, parameters, request, out result) : this.AddMethod((Method) new AssignChangePkgContentMethod(assignChangePkgContent, AssignChangePkgContentMethods.LoadESigDetails, (AssignChangePkgContent_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) assignChangePkgContent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((AssignChangePkgContent) null, (AssignChangePkgContent_LoadESigDetails_Parameters) null, (AssignChangePkgContent_Request) null, out AssignChangePkgContent_Result _);
    }

    public ResultStatus LoadESigDetails(AssignChangePkgContent assignChangePkgContent)
    {
      return this.LoadESigDetails(assignChangePkgContent, (AssignChangePkgContent_LoadESigDetails_Parameters) null, (AssignChangePkgContent_Request) null, out AssignChangePkgContent_Result _);
    }

    public ResultStatus LoadESigDetails(
      AssignChangePkgContent assignChangePkgContent,
      AssignChangePkgContent_Request request,
      out AssignChangePkgContent_Result result)
    {
      return this.LoadESigDetails(assignChangePkgContent, (AssignChangePkgContent_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      AssignChangePkgContent assignChangePkgContent,
      AssignChangePkgContent_Parameters parameters,
      AssignChangePkgContent_Request request,
      out AssignChangePkgContent_Result result)
    {
      result = (AssignChangePkgContent_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) assignChangePkgContent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignChangePkgContentService) this._Channel).ProcessComputation(this._UserProfile, assignChangePkgContent, parameters, request, out result) : this.AddMethod((Method) new AssignChangePkgContentMethod(assignChangePkgContent, AssignChangePkgContentMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) assignChangePkgContent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((AssignChangePkgContent) null, (AssignChangePkgContent_Parameters) null, (AssignChangePkgContent_Request) null, out AssignChangePkgContent_Result _);
    }

    public ResultStatus ProcessComputation(AssignChangePkgContent assignChangePkgContent)
    {
      return this.ProcessComputation(assignChangePkgContent, (AssignChangePkgContent_Parameters) null, (AssignChangePkgContent_Request) null, out AssignChangePkgContent_Result _);
    }

    public ResultStatus ProcessComputation(
      AssignChangePkgContent assignChangePkgContent,
      AssignChangePkgContent_Request request,
      out AssignChangePkgContent_Result result)
    {
      return this.ProcessComputation(assignChangePkgContent, (AssignChangePkgContent_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      AssignChangePkgContent assignChangePkgContent,
      AssignChangePkgContent_Parameters parameters,
      AssignChangePkgContent_Request request,
      out AssignChangePkgContent_Result result)
    {
      result = (AssignChangePkgContent_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) assignChangePkgContent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignChangePkgContentService) this._Channel).ResolveParametricData(this._UserProfile, assignChangePkgContent, parameters, request, out result) : this.AddMethod((Method) new AssignChangePkgContentMethod(assignChangePkgContent, AssignChangePkgContentMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) assignChangePkgContent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((AssignChangePkgContent) null, (AssignChangePkgContent_Parameters) null, (AssignChangePkgContent_Request) null, out AssignChangePkgContent_Result _);
    }

    public ResultStatus ResolveParametricData(
      AssignChangePkgContent assignChangePkgContent)
    {
      return this.ResolveParametricData(assignChangePkgContent, (AssignChangePkgContent_Parameters) null, (AssignChangePkgContent_Request) null, out AssignChangePkgContent_Result _);
    }

    public ResultStatus ResolveParametricData(
      AssignChangePkgContent assignChangePkgContent,
      AssignChangePkgContent_Request request,
      out AssignChangePkgContent_Result result)
    {
      return this.ResolveParametricData(assignChangePkgContent, (AssignChangePkgContent_Parameters) null, request, out result);
    }

    public ResultStatus SendEmailMessages(
      AssignChangePkgContent assignChangePkgContent,
      AssignChangePkgContent_Parameters parameters,
      AssignChangePkgContent_Request request,
      out AssignChangePkgContent_Result result)
    {
      result = (AssignChangePkgContent_Result) null;
      this.OnBeforeCall(nameof (SendEmailMessages), (DCObject) assignChangePkgContent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignChangePkgContentService) this._Channel).SendEmailMessages(this._UserProfile, assignChangePkgContent, parameters, request, out result) : this.AddMethod((Method) new AssignChangePkgContentMethod(assignChangePkgContent, AssignChangePkgContentMethods.SendEmailMessages, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SendEmailMessages), res, (DCObject) assignChangePkgContent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SendEmailMessages()
    {
      return this.SendEmailMessages((AssignChangePkgContent) null, (AssignChangePkgContent_Parameters) null, (AssignChangePkgContent_Request) null, out AssignChangePkgContent_Result _);
    }

    public ResultStatus SendEmailMessages(AssignChangePkgContent assignChangePkgContent)
    {
      return this.SendEmailMessages(assignChangePkgContent, (AssignChangePkgContent_Parameters) null, (AssignChangePkgContent_Request) null, out AssignChangePkgContent_Result _);
    }

    public ResultStatus SendEmailMessages(
      AssignChangePkgContent assignChangePkgContent,
      AssignChangePkgContent_Request request,
      out AssignChangePkgContent_Result result)
    {
      return this.SendEmailMessages(assignChangePkgContent, (AssignChangePkgContent_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject assignChangePkgContent,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AssignChangePkgContent_Result result1;
        ResultStatus parametricData = this.CreateParametricData((AssignChangePkgContent) assignChangePkgContent, (AssignChangePkgContent_Parameters) parameters, (AssignChangePkgContent_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject assignChangePkgContent,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AssignChangePkgContent_Result result1;
        ResultStatus actions = this.GetActions((AssignChangePkgContent) assignChangePkgContent, (AssignChangePkgContent_Parameters) parameters, (AssignChangePkgContent_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject assignChangePkgContent,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AssignChangePkgContent_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((AssignChangePkgContent) assignChangePkgContent, (AssignChangePkgContent_Parameters) parameters, (AssignChangePkgContent_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject assignChangePkgContent,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AssignChangePkgContent_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((AssignChangePkgContent) assignChangePkgContent, (AssignChangePkgContent_LoadESigDetails_Parameters) parameters, (AssignChangePkgContent_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject assignChangePkgContent,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AssignChangePkgContent_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((AssignChangePkgContent) assignChangePkgContent, (AssignChangePkgContent_Parameters) parameters, (AssignChangePkgContent_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject assignChangePkgContent,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AssignChangePkgContent_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((AssignChangePkgContent) assignChangePkgContent, (AssignChangePkgContent_Parameters) parameters, (AssignChangePkgContent_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject assignChangePkgContent,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AssignChangePkgContent_Result result1;
        ResultStatus resultStatus = this.Load((AssignChangePkgContent) assignChangePkgContent, (AssignChangePkgContent_Parameters) parameters, (AssignChangePkgContent_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject assignChangePkgContent,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AssignChangePkgContent_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((AssignChangePkgContent) assignChangePkgContent, (AssignChangePkgContent_Parameters) parameters, (AssignChangePkgContent_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      AssignChangePkgContent_Request request,
      out AssignChangePkgContent_Result result)
    {
      result = (AssignChangePkgContent_Result) null;
      try
      {
        AssignChangePkgContentMethod[] methods = new AssignChangePkgContentMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IAssignChangePkgContentService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnCommitTransaction(
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AssignChangePkgContent_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((AssignChangePkgContent_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      AssignChangePkgContent cdo,
      AssignChangePkgContent_Request request,
      out AssignChangePkgContent_Result result)
    {
      result = (AssignChangePkgContent_Result) null;
      try
      {
        return ((IAssignChangePkgContentService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetEnvironment(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AssignChangePkgContent_Result result1;
        ResultStatus environment = this.GetEnvironment((AssignChangePkgContent) cdo, (AssignChangePkgContent_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      AssignChangePkgContent_Request request,
      out AssignChangePkgContent_Result result)
    {
      return this.GetEnvironment((AssignChangePkgContent) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      AssignChangePkgContent cdo,
      AssignChangePkgContent_Request request,
      out AssignChangePkgContent_Result result)
    {
      result = (AssignChangePkgContent_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignChangePkgContentService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new AssignChangePkgContentMethod(cdo, AssignChangePkgContentMethods.ExecuteTransaction, (AssignChangePkgContent_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ExecuteTransaction), res, (DCObject) cdo, (Parameters) null, (Request) request, (Result) result);
      return res;
    }

    protected override ResultStatus OnExecuteTransaction(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AssignChangePkgContent_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((AssignChangePkgContent) cdo, (AssignChangePkgContent_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(AssignChangePkgContent cdo)
    {
      return this.ExecuteTransaction(cdo, (AssignChangePkgContent_Request) null, out AssignChangePkgContent_Result _);
    }

    public ResultStatus ExecuteTransaction(
      AssignChangePkgContent_Request request,
      out AssignChangePkgContent_Result result)
    {
      return this.ExecuteTransaction((AssignChangePkgContent) null, request, out result);
    }

    public ResultStatus AddDataTransaction(AssignChangePkgContent cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new AssignChangePkgContentMethod(cdo, AssignChangePkgContentMethods.AddDataTransaction, (AssignChangePkgContent_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
      {
        Result result;
        this.OnAfterCall(nameof (AddDataTransaction), res, (DCObject) cdo, (Parameters) null, (Request) null, result);
      }
      return res;
    }

    protected override ResultStatus OnAddDataTransaction(DCObject cdo)
    {
      try
      {
        return this.AddDataTransaction((AssignChangePkgContent) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
