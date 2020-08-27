// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.UpdateEventService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class UpdateEventService : QualityTxnBase
  {
    public UpdateEventService(UserProfile userProfile)
    {
      this.Initialize(typeof (IUpdateEventService), userProfile);
    }

    public ResultStatus CreateParametricData(
      UpdateEvent updateEvent,
      UpdateEvent_Parameters parameters,
      UpdateEvent_Request request,
      out UpdateEvent_Result result)
    {
      result = (UpdateEvent_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) updateEvent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventService) this._Channel).CreateParametricData(this._UserProfile, updateEvent, parameters, request, out result) : this.AddMethod((Method) new UpdateEventMethod(updateEvent, UpdateEventMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) updateEvent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((UpdateEvent) null, (UpdateEvent_Parameters) null, (UpdateEvent_Request) null, out UpdateEvent_Result _);
    }

    public ResultStatus CreateParametricData(UpdateEvent updateEvent)
    {
      return this.CreateParametricData(updateEvent, (UpdateEvent_Parameters) null, (UpdateEvent_Request) null, out UpdateEvent_Result _);
    }

    public ResultStatus CreateParametricData(
      UpdateEvent updateEvent,
      UpdateEvent_Request request,
      out UpdateEvent_Result result)
    {
      return this.CreateParametricData(updateEvent, (UpdateEvent_Parameters) null, request, out result);
    }

    public ResultStatus ExecuteChecklist(
      UpdateEvent updateEvent,
      UpdateEvent_Parameters parameters,
      UpdateEvent_Request request,
      out UpdateEvent_Result result)
    {
      result = (UpdateEvent_Result) null;
      this.OnBeforeCall(nameof (ExecuteChecklist), (DCObject) updateEvent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventService) this._Channel).ExecuteChecklist(this._UserProfile, updateEvent, parameters, request, out result) : this.AddMethod((Method) new UpdateEventMethod(updateEvent, UpdateEventMethods.ExecuteChecklist, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ExecuteChecklist), res, (DCObject) updateEvent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ExecuteChecklist()
    {
      return this.ExecuteChecklist((UpdateEvent) null, (UpdateEvent_Parameters) null, (UpdateEvent_Request) null, out UpdateEvent_Result _);
    }

    public ResultStatus ExecuteChecklist(UpdateEvent updateEvent)
    {
      return this.ExecuteChecklist(updateEvent, (UpdateEvent_Parameters) null, (UpdateEvent_Request) null, out UpdateEvent_Result _);
    }

    public ResultStatus ExecuteChecklist(
      UpdateEvent updateEvent,
      UpdateEvent_Request request,
      out UpdateEvent_Result result)
    {
      return this.ExecuteChecklist(updateEvent, (UpdateEvent_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      UpdateEvent updateEvent,
      UpdateEvent_Parameters parameters,
      UpdateEvent_Request request,
      out UpdateEvent_Result result)
    {
      result = (UpdateEvent_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) updateEvent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventService) this._Channel).GetActions(this._UserProfile, updateEvent, parameters, request, out result) : this.AddMethod((Method) new UpdateEventMethod(updateEvent, UpdateEventMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) updateEvent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((UpdateEvent) null, (UpdateEvent_Parameters) null, (UpdateEvent_Request) null, out UpdateEvent_Result _);
    }

    public ResultStatus GetActions(UpdateEvent updateEvent)
    {
      return this.GetActions(updateEvent, (UpdateEvent_Parameters) null, (UpdateEvent_Request) null, out UpdateEvent_Result _);
    }

    public ResultStatus GetActions(
      UpdateEvent updateEvent,
      UpdateEvent_Request request,
      out UpdateEvent_Result result)
    {
      return this.GetActions(updateEvent, (UpdateEvent_Parameters) null, request, out result);
    }

    public ResultStatus GetApprovalSheetDetails(
      UpdateEvent updateEvent,
      UpdateEvent_Parameters parameters,
      UpdateEvent_Request request,
      out UpdateEvent_Result result)
    {
      result = (UpdateEvent_Result) null;
      this.OnBeforeCall(nameof (GetApprovalSheetDetails), (DCObject) updateEvent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventService) this._Channel).GetApprovalSheetDetails(this._UserProfile, updateEvent, parameters, request, out result) : this.AddMethod((Method) new UpdateEventMethod(updateEvent, UpdateEventMethods.GetApprovalSheetDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetApprovalSheetDetails), res, (DCObject) updateEvent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetApprovalSheetDetails()
    {
      return this.GetApprovalSheetDetails((UpdateEvent) null, (UpdateEvent_Parameters) null, (UpdateEvent_Request) null, out UpdateEvent_Result _);
    }

    public ResultStatus GetApprovalSheetDetails(UpdateEvent updateEvent)
    {
      return this.GetApprovalSheetDetails(updateEvent, (UpdateEvent_Parameters) null, (UpdateEvent_Request) null, out UpdateEvent_Result _);
    }

    public ResultStatus GetApprovalSheetDetails(
      UpdateEvent updateEvent,
      UpdateEvent_Request request,
      out UpdateEvent_Result result)
    {
      return this.GetApprovalSheetDetails(updateEvent, (UpdateEvent_Parameters) null, request, out result);
    }

    public ResultStatus GetApprovalSheetTemplate(
      UpdateEvent updateEvent,
      UpdateEvent_Parameters parameters,
      UpdateEvent_Request request,
      out UpdateEvent_Result result)
    {
      result = (UpdateEvent_Result) null;
      this.OnBeforeCall(nameof (GetApprovalSheetTemplate), (DCObject) updateEvent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventService) this._Channel).GetApprovalSheetTemplate(this._UserProfile, updateEvent, parameters, request, out result) : this.AddMethod((Method) new UpdateEventMethod(updateEvent, UpdateEventMethods.GetApprovalSheetTemplate, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetApprovalSheetTemplate), res, (DCObject) updateEvent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetApprovalSheetTemplate()
    {
      return this.GetApprovalSheetTemplate((UpdateEvent) null, (UpdateEvent_Parameters) null, (UpdateEvent_Request) null, out UpdateEvent_Result _);
    }

    public ResultStatus GetApprovalSheetTemplate(UpdateEvent updateEvent)
    {
      return this.GetApprovalSheetTemplate(updateEvent, (UpdateEvent_Parameters) null, (UpdateEvent_Request) null, out UpdateEvent_Result _);
    }

    public ResultStatus GetApprovalSheetTemplate(
      UpdateEvent updateEvent,
      UpdateEvent_Request request,
      out UpdateEvent_Result result)
    {
      return this.GetApprovalSheetTemplate(updateEvent, (UpdateEvent_Parameters) null, request, out result);
    }

    public ResultStatus GetChecklistEntries(
      UpdateEvent updateEvent,
      UpdateEvent_Parameters parameters,
      UpdateEvent_Request request,
      out UpdateEvent_Result result)
    {
      result = (UpdateEvent_Result) null;
      this.OnBeforeCall(nameof (GetChecklistEntries), (DCObject) updateEvent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventService) this._Channel).GetChecklistEntries(this._UserProfile, updateEvent, parameters, request, out result) : this.AddMethod((Method) new UpdateEventMethod(updateEvent, UpdateEventMethods.GetChecklistEntries, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetChecklistEntries), res, (DCObject) updateEvent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetChecklistEntries()
    {
      return this.GetChecklistEntries((UpdateEvent) null, (UpdateEvent_Parameters) null, (UpdateEvent_Request) null, out UpdateEvent_Result _);
    }

    public ResultStatus GetChecklistEntries(UpdateEvent updateEvent)
    {
      return this.GetChecklistEntries(updateEvent, (UpdateEvent_Parameters) null, (UpdateEvent_Request) null, out UpdateEvent_Result _);
    }

    public ResultStatus GetChecklistEntries(
      UpdateEvent updateEvent,
      UpdateEvent_Request request,
      out UpdateEvent_Result result)
    {
      return this.GetChecklistEntries(updateEvent, (UpdateEvent_Parameters) null, request, out result);
    }

    public ResultStatus GetCrossRefDetails(
      UpdateEvent updateEvent,
      UpdateEvent_Parameters parameters,
      UpdateEvent_Request request,
      out UpdateEvent_Result result)
    {
      result = (UpdateEvent_Result) null;
      this.OnBeforeCall(nameof (GetCrossRefDetails), (DCObject) updateEvent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventService) this._Channel).GetCrossRefDetails(this._UserProfile, updateEvent, parameters, request, out result) : this.AddMethod((Method) new UpdateEventMethod(updateEvent, UpdateEventMethods.GetCrossRefDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetCrossRefDetails), res, (DCObject) updateEvent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetCrossRefDetails()
    {
      return this.GetCrossRefDetails((UpdateEvent) null, (UpdateEvent_Parameters) null, (UpdateEvent_Request) null, out UpdateEvent_Result _);
    }

    public ResultStatus GetCrossRefDetails(UpdateEvent updateEvent)
    {
      return this.GetCrossRefDetails(updateEvent, (UpdateEvent_Parameters) null, (UpdateEvent_Request) null, out UpdateEvent_Result _);
    }

    public ResultStatus GetCrossRefDetails(
      UpdateEvent updateEvent,
      UpdateEvent_Request request,
      out UpdateEvent_Result result)
    {
      return this.GetCrossRefDetails(updateEvent, (UpdateEvent_Parameters) null, request, out result);
    }

    public ResultStatus GetCrossReferences(
      UpdateEvent updateEvent,
      UpdateEvent_Parameters parameters,
      UpdateEvent_Request request,
      out UpdateEvent_Result result)
    {
      result = (UpdateEvent_Result) null;
      this.OnBeforeCall(nameof (GetCrossReferences), (DCObject) updateEvent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventService) this._Channel).GetCrossReferences(this._UserProfile, updateEvent, parameters, request, out result) : this.AddMethod((Method) new UpdateEventMethod(updateEvent, UpdateEventMethods.GetCrossReferences, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetCrossReferences), res, (DCObject) updateEvent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetCrossReferences()
    {
      return this.GetCrossReferences((UpdateEvent) null, (UpdateEvent_Parameters) null, (UpdateEvent_Request) null, out UpdateEvent_Result _);
    }

    public ResultStatus GetCrossReferences(UpdateEvent updateEvent)
    {
      return this.GetCrossReferences(updateEvent, (UpdateEvent_Parameters) null, (UpdateEvent_Request) null, out UpdateEvent_Result _);
    }

    public ResultStatus GetCrossReferences(
      UpdateEvent updateEvent,
      UpdateEvent_Request request,
      out UpdateEvent_Result result)
    {
      return this.GetCrossReferences(updateEvent, (UpdateEvent_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      UpdateEvent updateEvent,
      UpdateEvent_Parameters parameters,
      UpdateEvent_Request request,
      out UpdateEvent_Result result)
    {
      result = (UpdateEvent_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) updateEvent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventService) this._Channel).GetDataPoints(this._UserProfile, updateEvent, parameters, request, out result) : this.AddMethod((Method) new UpdateEventMethod(updateEvent, UpdateEventMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) updateEvent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((UpdateEvent) null, (UpdateEvent_Parameters) null, (UpdateEvent_Request) null, out UpdateEvent_Result _);
    }

    public ResultStatus GetDataPoints(UpdateEvent updateEvent)
    {
      return this.GetDataPoints(updateEvent, (UpdateEvent_Parameters) null, (UpdateEvent_Request) null, out UpdateEvent_Result _);
    }

    public ResultStatus GetDataPoints(
      UpdateEvent updateEvent,
      UpdateEvent_Request request,
      out UpdateEvent_Result result)
    {
      return this.GetDataPoints(updateEvent, (UpdateEvent_Parameters) null, request, out result);
    }

    public ResultStatus GetDetails(
      UpdateEvent updateEvent,
      UpdateEvent_Parameters parameters,
      UpdateEvent_Request request,
      out UpdateEvent_Result result)
    {
      result = (UpdateEvent_Result) null;
      this.OnBeforeCall(nameof (GetDetails), (DCObject) updateEvent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventService) this._Channel).GetDetails(this._UserProfile, updateEvent, parameters, request, out result) : this.AddMethod((Method) new UpdateEventMethod(updateEvent, UpdateEventMethods.GetDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDetails), res, (DCObject) updateEvent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDetails()
    {
      return this.GetDetails((UpdateEvent) null, (UpdateEvent_Parameters) null, (UpdateEvent_Request) null, out UpdateEvent_Result _);
    }

    public ResultStatus GetDetails(UpdateEvent updateEvent)
    {
      return this.GetDetails(updateEvent, (UpdateEvent_Parameters) null, (UpdateEvent_Request) null, out UpdateEvent_Result _);
    }

    public ResultStatus GetDetails(
      UpdateEvent updateEvent,
      UpdateEvent_Request request,
      out UpdateEvent_Result result)
    {
      return this.GetDetails(updateEvent, (UpdateEvent_Parameters) null, request, out result);
    }

    public ResultStatus GetEventDetails(
      UpdateEvent updateEvent,
      UpdateEvent_Parameters parameters,
      UpdateEvent_Request request,
      out UpdateEvent_Result result)
    {
      result = (UpdateEvent_Result) null;
      this.OnBeforeCall(nameof (GetEventDetails), (DCObject) updateEvent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventService) this._Channel).GetEventDetails(this._UserProfile, updateEvent, parameters, request, out result) : this.AddMethod((Method) new UpdateEventMethod(updateEvent, UpdateEventMethods.GetEventDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetEventDetails), res, (DCObject) updateEvent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetEventDetails()
    {
      return this.GetEventDetails((UpdateEvent) null, (UpdateEvent_Parameters) null, (UpdateEvent_Request) null, out UpdateEvent_Result _);
    }

    public ResultStatus GetEventDetails(UpdateEvent updateEvent)
    {
      return this.GetEventDetails(updateEvent, (UpdateEvent_Parameters) null, (UpdateEvent_Request) null, out UpdateEvent_Result _);
    }

    public ResultStatus GetEventDetails(
      UpdateEvent updateEvent,
      UpdateEvent_Request request,
      out UpdateEvent_Result result)
    {
      return this.GetEventDetails(updateEvent, (UpdateEvent_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      UpdateEvent updateEvent,
      UpdateEvent_Parameters parameters,
      UpdateEvent_Request request,
      out UpdateEvent_Result result)
    {
      result = (UpdateEvent_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) updateEvent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventService) this._Channel).GetWIPMsgs(this._UserProfile, updateEvent, parameters, request, out result) : this.AddMethod((Method) new UpdateEventMethod(updateEvent, UpdateEventMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) updateEvent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((UpdateEvent) null, (UpdateEvent_Parameters) null, (UpdateEvent_Request) null, out UpdateEvent_Result _);
    }

    public ResultStatus GetWIPMsgs(UpdateEvent updateEvent)
    {
      return this.GetWIPMsgs(updateEvent, (UpdateEvent_Parameters) null, (UpdateEvent_Request) null, out UpdateEvent_Result _);
    }

    public ResultStatus GetWIPMsgs(
      UpdateEvent updateEvent,
      UpdateEvent_Request request,
      out UpdateEvent_Result result)
    {
      return this.GetWIPMsgs(updateEvent, (UpdateEvent_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      UpdateEvent updateEvent,
      UpdateEvent_Parameters parameters,
      UpdateEvent_Request request,
      out UpdateEvent_Result result)
    {
      result = (UpdateEvent_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) updateEvent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventService) this._Channel).Load(this._UserProfile, updateEvent, parameters, request, out result) : this.AddMethod((Method) new UpdateEventMethod(updateEvent, UpdateEventMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) updateEvent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((UpdateEvent) null, (UpdateEvent_Parameters) null, (UpdateEvent_Request) null, out UpdateEvent_Result _);
    }

    public ResultStatus Load(UpdateEvent updateEvent)
    {
      return this.Load(updateEvent, (UpdateEvent_Parameters) null, (UpdateEvent_Request) null, out UpdateEvent_Result _);
    }

    public ResultStatus Load(
      UpdateEvent updateEvent,
      UpdateEvent_Request request,
      out UpdateEvent_Result result)
    {
      return this.Load(updateEvent, (UpdateEvent_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      UpdateEvent updateEvent,
      UpdateEvent_Parameters parameters,
      UpdateEvent_Request request,
      out UpdateEvent_Result result)
    {
      result = (UpdateEvent_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) updateEvent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventService) this._Channel).LoadESigDetails(this._UserProfile, updateEvent, parameters, request, out result) : this.AddMethod((Method) new UpdateEventMethod(updateEvent, UpdateEventMethods.LoadESigDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) updateEvent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((UpdateEvent) null, (UpdateEvent_Parameters) null, (UpdateEvent_Request) null, out UpdateEvent_Result _);
    }

    public ResultStatus LoadESigDetails(UpdateEvent updateEvent)
    {
      return this.LoadESigDetails(updateEvent, (UpdateEvent_Parameters) null, (UpdateEvent_Request) null, out UpdateEvent_Result _);
    }

    public ResultStatus LoadESigDetails(
      UpdateEvent updateEvent,
      UpdateEvent_Request request,
      out UpdateEvent_Result result)
    {
      return this.LoadESigDetails(updateEvent, (UpdateEvent_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      UpdateEvent updateEvent,
      UpdateEvent_Parameters parameters,
      UpdateEvent_Request request,
      out UpdateEvent_Result result)
    {
      result = (UpdateEvent_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) updateEvent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventService) this._Channel).ProcessComputation(this._UserProfile, updateEvent, parameters, request, out result) : this.AddMethod((Method) new UpdateEventMethod(updateEvent, UpdateEventMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) updateEvent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((UpdateEvent) null, (UpdateEvent_Parameters) null, (UpdateEvent_Request) null, out UpdateEvent_Result _);
    }

    public ResultStatus ProcessComputation(UpdateEvent updateEvent)
    {
      return this.ProcessComputation(updateEvent, (UpdateEvent_Parameters) null, (UpdateEvent_Request) null, out UpdateEvent_Result _);
    }

    public ResultStatus ProcessComputation(
      UpdateEvent updateEvent,
      UpdateEvent_Request request,
      out UpdateEvent_Result result)
    {
      return this.ProcessComputation(updateEvent, (UpdateEvent_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      UpdateEvent updateEvent,
      UpdateEvent_Parameters parameters,
      UpdateEvent_Request request,
      out UpdateEvent_Result result)
    {
      result = (UpdateEvent_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) updateEvent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventService) this._Channel).ResolveParametricData(this._UserProfile, updateEvent, parameters, request, out result) : this.AddMethod((Method) new UpdateEventMethod(updateEvent, UpdateEventMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) updateEvent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((UpdateEvent) null, (UpdateEvent_Parameters) null, (UpdateEvent_Request) null, out UpdateEvent_Result _);
    }

    public ResultStatus ResolveParametricData(UpdateEvent updateEvent)
    {
      return this.ResolveParametricData(updateEvent, (UpdateEvent_Parameters) null, (UpdateEvent_Request) null, out UpdateEvent_Result _);
    }

    public ResultStatus ResolveParametricData(
      UpdateEvent updateEvent,
      UpdateEvent_Request request,
      out UpdateEvent_Result result)
    {
      return this.ResolveParametricData(updateEvent, (UpdateEvent_Parameters) null, request, out result);
    }

    public ResultStatus SaveApprovalSheet(
      UpdateEvent updateEvent,
      UpdateEvent_Parameters parameters,
      UpdateEvent_Request request,
      out UpdateEvent_Result result)
    {
      result = (UpdateEvent_Result) null;
      this.OnBeforeCall(nameof (SaveApprovalSheet), (DCObject) updateEvent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventService) this._Channel).SaveApprovalSheet(this._UserProfile, updateEvent, parameters, request, out result) : this.AddMethod((Method) new UpdateEventMethod(updateEvent, UpdateEventMethods.SaveApprovalSheet, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveApprovalSheet), res, (DCObject) updateEvent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveApprovalSheet()
    {
      return this.SaveApprovalSheet((UpdateEvent) null, (UpdateEvent_Parameters) null, (UpdateEvent_Request) null, out UpdateEvent_Result _);
    }

    public ResultStatus SaveApprovalSheet(UpdateEvent updateEvent)
    {
      return this.SaveApprovalSheet(updateEvent, (UpdateEvent_Parameters) null, (UpdateEvent_Request) null, out UpdateEvent_Result _);
    }

    public ResultStatus SaveApprovalSheet(
      UpdateEvent updateEvent,
      UpdateEvent_Request request,
      out UpdateEvent_Result result)
    {
      return this.SaveApprovalSheet(updateEvent, (UpdateEvent_Parameters) null, request, out result);
    }

    public ResultStatus SaveCrossReferences(
      UpdateEvent updateEvent,
      UpdateEvent_Parameters parameters,
      UpdateEvent_Request request,
      out UpdateEvent_Result result)
    {
      result = (UpdateEvent_Result) null;
      this.OnBeforeCall(nameof (SaveCrossReferences), (DCObject) updateEvent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventService) this._Channel).SaveCrossReferences(this._UserProfile, updateEvent, parameters, request, out result) : this.AddMethod((Method) new UpdateEventMethod(updateEvent, UpdateEventMethods.SaveCrossReferences, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveCrossReferences), res, (DCObject) updateEvent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveCrossReferences()
    {
      return this.SaveCrossReferences((UpdateEvent) null, (UpdateEvent_Parameters) null, (UpdateEvent_Request) null, out UpdateEvent_Result _);
    }

    public ResultStatus SaveCrossReferences(UpdateEvent updateEvent)
    {
      return this.SaveCrossReferences(updateEvent, (UpdateEvent_Parameters) null, (UpdateEvent_Request) null, out UpdateEvent_Result _);
    }

    public ResultStatus SaveCrossReferences(
      UpdateEvent updateEvent,
      UpdateEvent_Request request,
      out UpdateEvent_Result result)
    {
      return this.SaveCrossReferences(updateEvent, (UpdateEvent_Parameters) null, request, out result);
    }

    public ResultStatus SubmitEvent(
      UpdateEvent updateEvent,
      UpdateEvent_Parameters parameters,
      UpdateEvent_Request request,
      out UpdateEvent_Result result)
    {
      result = (UpdateEvent_Result) null;
      this.OnBeforeCall(nameof (SubmitEvent), (DCObject) updateEvent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventService) this._Channel).SubmitEvent(this._UserProfile, updateEvent, parameters, request, out result) : this.AddMethod((Method) new UpdateEventMethod(updateEvent, UpdateEventMethods.SubmitEvent, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SubmitEvent), res, (DCObject) updateEvent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SubmitEvent()
    {
      return this.SubmitEvent((UpdateEvent) null, (UpdateEvent_Parameters) null, (UpdateEvent_Request) null, out UpdateEvent_Result _);
    }

    public ResultStatus SubmitEvent(UpdateEvent updateEvent)
    {
      return this.SubmitEvent(updateEvent, (UpdateEvent_Parameters) null, (UpdateEvent_Request) null, out UpdateEvent_Result _);
    }

    public ResultStatus SubmitEvent(
      UpdateEvent updateEvent,
      UpdateEvent_Request request,
      out UpdateEvent_Result result)
    {
      return this.SubmitEvent(updateEvent, (UpdateEvent_Parameters) null, request, out result);
    }

    public ResultStatus ValidateEvent(
      UpdateEvent updateEvent,
      UpdateEvent_Parameters parameters,
      UpdateEvent_Request request,
      out UpdateEvent_Result result)
    {
      result = (UpdateEvent_Result) null;
      this.OnBeforeCall(nameof (ValidateEvent), (DCObject) updateEvent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventService) this._Channel).ValidateEvent(this._UserProfile, updateEvent, parameters, request, out result) : this.AddMethod((Method) new UpdateEventMethod(updateEvent, UpdateEventMethods.ValidateEvent, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateEvent), res, (DCObject) updateEvent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateEvent()
    {
      return this.ValidateEvent((UpdateEvent) null, (UpdateEvent_Parameters) null, (UpdateEvent_Request) null, out UpdateEvent_Result _);
    }

    public ResultStatus ValidateEvent(UpdateEvent updateEvent)
    {
      return this.ValidateEvent(updateEvent, (UpdateEvent_Parameters) null, (UpdateEvent_Request) null, out UpdateEvent_Result _);
    }

    public ResultStatus ValidateEvent(
      UpdateEvent updateEvent,
      UpdateEvent_Request request,
      out UpdateEvent_Result result)
    {
      return this.ValidateEvent(updateEvent, (UpdateEvent_Parameters) null, request, out result);
    }

    public ResultStatus ValidateIfChecklistHasResponses(
      UpdateEvent updateEvent,
      UpdateEvent_Parameters parameters,
      UpdateEvent_Request request,
      out UpdateEvent_Result result)
    {
      result = (UpdateEvent_Result) null;
      this.OnBeforeCall(nameof (ValidateIfChecklistHasResponses), (DCObject) updateEvent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventService) this._Channel).ValidateIfChecklistHasResponses(this._UserProfile, updateEvent, parameters, request, out result) : this.AddMethod((Method) new UpdateEventMethod(updateEvent, UpdateEventMethods.ValidateIfChecklistHasResponses, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateIfChecklistHasResponses), res, (DCObject) updateEvent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateIfChecklistHasResponses()
    {
      return this.ValidateIfChecklistHasResponses((UpdateEvent) null, (UpdateEvent_Parameters) null, (UpdateEvent_Request) null, out UpdateEvent_Result _);
    }

    public ResultStatus ValidateIfChecklistHasResponses(UpdateEvent updateEvent)
    {
      return this.ValidateIfChecklistHasResponses(updateEvent, (UpdateEvent_Parameters) null, (UpdateEvent_Request) null, out UpdateEvent_Result _);
    }

    public ResultStatus ValidateIfChecklistHasResponses(
      UpdateEvent updateEvent,
      UpdateEvent_Request request,
      out UpdateEvent_Result result)
    {
      return this.ValidateIfChecklistHasResponses(updateEvent, (UpdateEvent_Parameters) null, request, out result);
    }

    public ResultStatus ValidateOwner(
      UpdateEvent updateEvent,
      UpdateEvent_Parameters parameters,
      UpdateEvent_Request request,
      out UpdateEvent_Result result)
    {
      result = (UpdateEvent_Result) null;
      this.OnBeforeCall(nameof (ValidateOwner), (DCObject) updateEvent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventService) this._Channel).ValidateOwner(this._UserProfile, updateEvent, parameters, request, out result) : this.AddMethod((Method) new UpdateEventMethod(updateEvent, UpdateEventMethods.ValidateOwner, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateOwner), res, (DCObject) updateEvent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateOwner()
    {
      return this.ValidateOwner((UpdateEvent) null, (UpdateEvent_Parameters) null, (UpdateEvent_Request) null, out UpdateEvent_Result _);
    }

    public ResultStatus ValidateOwner(UpdateEvent updateEvent)
    {
      return this.ValidateOwner(updateEvent, (UpdateEvent_Parameters) null, (UpdateEvent_Request) null, out UpdateEvent_Result _);
    }

    public ResultStatus ValidateOwner(
      UpdateEvent updateEvent,
      UpdateEvent_Request request,
      out UpdateEvent_Result result)
    {
      return this.ValidateOwner(updateEvent, (UpdateEvent_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject updateEvent,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEvent_Result result1;
        ResultStatus parametricData = this.CreateParametricData((UpdateEvent) updateEvent, (UpdateEvent_Parameters) parameters, (UpdateEvent_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject updateEvent,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEvent_Result result1;
        ResultStatus actions = this.GetActions((UpdateEvent) updateEvent, (UpdateEvent_Parameters) parameters, (UpdateEvent_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject updateEvent,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEvent_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((UpdateEvent) updateEvent, (UpdateEvent_Parameters) parameters, (UpdateEvent_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject updateEvent,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEvent_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((UpdateEvent) updateEvent, (UpdateEvent_Parameters) parameters, (UpdateEvent_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject updateEvent,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEvent_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((UpdateEvent) updateEvent, (UpdateEvent_Parameters) parameters, (UpdateEvent_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject updateEvent,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEvent_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((UpdateEvent) updateEvent, (UpdateEvent_Parameters) parameters, (UpdateEvent_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject updateEvent,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEvent_Result result1;
        ResultStatus resultStatus = this.Load((UpdateEvent) updateEvent, (UpdateEvent_Parameters) parameters, (UpdateEvent_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject updateEvent,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEvent_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((UpdateEvent) updateEvent, (UpdateEvent_Parameters) parameters, (UpdateEvent_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      UpdateEvent_Request request,
      out UpdateEvent_Result result)
    {
      result = (UpdateEvent_Result) null;
      try
      {
        UpdateEventMethod[] methods = new UpdateEventMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IUpdateEventService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        UpdateEvent_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((UpdateEvent_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      UpdateEvent cdo,
      UpdateEvent_Request request,
      out UpdateEvent_Result result)
    {
      result = (UpdateEvent_Result) null;
      try
      {
        return ((IUpdateEventService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        UpdateEvent_Result result1;
        ResultStatus environment = this.GetEnvironment((UpdateEvent) cdo, (UpdateEvent_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      UpdateEvent_Request request,
      out UpdateEvent_Result result)
    {
      return this.GetEnvironment((UpdateEvent) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      UpdateEvent cdo,
      UpdateEvent_Request request,
      out UpdateEvent_Result result)
    {
      result = (UpdateEvent_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new UpdateEventMethod(cdo, UpdateEventMethods.ExecuteTransaction, (UpdateEvent_Parameters) null));
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
        UpdateEvent_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((UpdateEvent) cdo, (UpdateEvent_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(UpdateEvent cdo)
    {
      return this.ExecuteTransaction(cdo, (UpdateEvent_Request) null, out UpdateEvent_Result _);
    }

    public ResultStatus ExecuteTransaction(
      UpdateEvent_Request request,
      out UpdateEvent_Result result)
    {
      return this.ExecuteTransaction((UpdateEvent) null, request, out result);
    }

    public ResultStatus AddDataTransaction(UpdateEvent cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new UpdateEventMethod(cdo, UpdateEventMethods.AddDataTransaction, (UpdateEvent_Parameters) null));
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
        return this.AddDataTransaction((UpdateEvent) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
