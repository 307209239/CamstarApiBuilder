// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.DataPointCollectionDefMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class DataPointCollectionDefMaintService : DataCollectionDefMaintBase
  {
    public DataPointCollectionDefMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IDataPointCollectionDefMaintService), userProfile);
    }

    public ResultStatus Delete(
      DataPointCollectionDefMaint dataPointCollectionDefMaint,
      DataPointCollectionDefMaint_Parameters parameters,
      DataPointCollectionDefMaint_Request request,
      out DataPointCollectionDefMaint_Result result)
    {
      result = (DataPointCollectionDefMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) dataPointCollectionDefMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDataPointCollectionDefMaintService) this._Channel).Delete(this._UserProfile, dataPointCollectionDefMaint, parameters, request, out result) : this.AddMethod((Method) new DataPointCollectionDefMaintMethod(dataPointCollectionDefMaint, DataPointCollectionDefMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) dataPointCollectionDefMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((DataPointCollectionDefMaint) null, (DataPointCollectionDefMaint_Parameters) null, (DataPointCollectionDefMaint_Request) null, out DataPointCollectionDefMaint_Result _);
    }

    public ResultStatus Delete(
      DataPointCollectionDefMaint dataPointCollectionDefMaint)
    {
      return this.Delete(dataPointCollectionDefMaint, (DataPointCollectionDefMaint_Parameters) null, (DataPointCollectionDefMaint_Request) null, out DataPointCollectionDefMaint_Result _);
    }

    public ResultStatus Delete(
      DataPointCollectionDefMaint dataPointCollectionDefMaint,
      DataPointCollectionDefMaint_Request request,
      out DataPointCollectionDefMaint_Result result)
    {
      return this.Delete(dataPointCollectionDefMaint, (DataPointCollectionDefMaint_Parameters) null, request, out result);
    }

    public ResultStatus DeleteAllRevisions(
      DataPointCollectionDefMaint dataPointCollectionDefMaint,
      DataPointCollectionDefMaint_Parameters parameters,
      DataPointCollectionDefMaint_Request request,
      out DataPointCollectionDefMaint_Result result)
    {
      result = (DataPointCollectionDefMaint_Result) null;
      this.OnBeforeCall(nameof (DeleteAllRevisions), (DCObject) dataPointCollectionDefMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDataPointCollectionDefMaintService) this._Channel).DeleteAllRevisions(this._UserProfile, dataPointCollectionDefMaint, parameters, request, out result) : this.AddMethod((Method) new DataPointCollectionDefMaintMethod(dataPointCollectionDefMaint, DataPointCollectionDefMaintMethods.DeleteAllRevisions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (DeleteAllRevisions), res, (DCObject) dataPointCollectionDefMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus DeleteAllRevisions()
    {
      return this.DeleteAllRevisions((DataPointCollectionDefMaint) null, (DataPointCollectionDefMaint_Parameters) null, (DataPointCollectionDefMaint_Request) null, out DataPointCollectionDefMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(
      DataPointCollectionDefMaint dataPointCollectionDefMaint)
    {
      return this.DeleteAllRevisions(dataPointCollectionDefMaint, (DataPointCollectionDefMaint_Parameters) null, (DataPointCollectionDefMaint_Request) null, out DataPointCollectionDefMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(
      DataPointCollectionDefMaint dataPointCollectionDefMaint,
      DataPointCollectionDefMaint_Request request,
      out DataPointCollectionDefMaint_Result result)
    {
      return this.DeleteAllRevisions(dataPointCollectionDefMaint, (DataPointCollectionDefMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      DataPointCollectionDefMaint dataPointCollectionDefMaint,
      DataPointCollectionDefMaint_Parameters parameters,
      DataPointCollectionDefMaint_Request request,
      out DataPointCollectionDefMaint_Result result)
    {
      result = (DataPointCollectionDefMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) dataPointCollectionDefMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDataPointCollectionDefMaintService) this._Channel).Freeze(this._UserProfile, dataPointCollectionDefMaint, parameters, request, out result) : this.AddMethod((Method) new DataPointCollectionDefMaintMethod(dataPointCollectionDefMaint, DataPointCollectionDefMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) dataPointCollectionDefMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((DataPointCollectionDefMaint) null, (DataPointCollectionDefMaint_Parameters) null, (DataPointCollectionDefMaint_Request) null, out DataPointCollectionDefMaint_Result _);
    }

    public ResultStatus Freeze(
      DataPointCollectionDefMaint dataPointCollectionDefMaint)
    {
      return this.Freeze(dataPointCollectionDefMaint, (DataPointCollectionDefMaint_Parameters) null, (DataPointCollectionDefMaint_Request) null, out DataPointCollectionDefMaint_Result _);
    }

    public ResultStatus Freeze(
      DataPointCollectionDefMaint dataPointCollectionDefMaint,
      DataPointCollectionDefMaint_Request request,
      out DataPointCollectionDefMaint_Result result)
    {
      return this.Freeze(dataPointCollectionDefMaint, (DataPointCollectionDefMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      DataPointCollectionDefMaint dataPointCollectionDefMaint,
      DataPointCollectionDefMaint_Parameters parameters,
      DataPointCollectionDefMaint_Request request,
      out DataPointCollectionDefMaint_Result result)
    {
      result = (DataPointCollectionDefMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) dataPointCollectionDefMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDataPointCollectionDefMaintService) this._Channel).GetWIPMsgs(this._UserProfile, dataPointCollectionDefMaint, parameters, request, out result) : this.AddMethod((Method) new DataPointCollectionDefMaintMethod(dataPointCollectionDefMaint, DataPointCollectionDefMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) dataPointCollectionDefMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((DataPointCollectionDefMaint) null, (DataPointCollectionDefMaint_Parameters) null, (DataPointCollectionDefMaint_Request) null, out DataPointCollectionDefMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      DataPointCollectionDefMaint dataPointCollectionDefMaint)
    {
      return this.GetWIPMsgs(dataPointCollectionDefMaint, (DataPointCollectionDefMaint_Parameters) null, (DataPointCollectionDefMaint_Request) null, out DataPointCollectionDefMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      DataPointCollectionDefMaint dataPointCollectionDefMaint,
      DataPointCollectionDefMaint_Request request,
      out DataPointCollectionDefMaint_Result result)
    {
      return this.GetWIPMsgs(dataPointCollectionDefMaint, (DataPointCollectionDefMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      DataPointCollectionDefMaint dataPointCollectionDefMaint,
      DataPointCollectionDefMaint_Parameters parameters,
      DataPointCollectionDefMaint_Request request,
      out DataPointCollectionDefMaint_Result result)
    {
      result = (DataPointCollectionDefMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) dataPointCollectionDefMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDataPointCollectionDefMaintService) this._Channel).Load(this._UserProfile, dataPointCollectionDefMaint, parameters, request, out result) : this.AddMethod((Method) new DataPointCollectionDefMaintMethod(dataPointCollectionDefMaint, DataPointCollectionDefMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) dataPointCollectionDefMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((DataPointCollectionDefMaint) null, (DataPointCollectionDefMaint_Parameters) null, (DataPointCollectionDefMaint_Request) null, out DataPointCollectionDefMaint_Result _);
    }

    public ResultStatus Load(
      DataPointCollectionDefMaint dataPointCollectionDefMaint)
    {
      return this.Load(dataPointCollectionDefMaint, (DataPointCollectionDefMaint_Parameters) null, (DataPointCollectionDefMaint_Request) null, out DataPointCollectionDefMaint_Result _);
    }

    public ResultStatus Load(
      DataPointCollectionDefMaint dataPointCollectionDefMaint,
      DataPointCollectionDefMaint_Request request,
      out DataPointCollectionDefMaint_Result result)
    {
      return this.Load(dataPointCollectionDefMaint, (DataPointCollectionDefMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      DataPointCollectionDefMaint dataPointCollectionDefMaint,
      DataPointCollectionDefMaint_LoadESigDetails_Parameters parameters,
      DataPointCollectionDefMaint_Request request,
      out DataPointCollectionDefMaint_Result result)
    {
      result = (DataPointCollectionDefMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) dataPointCollectionDefMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDataPointCollectionDefMaintService) this._Channel).LoadESigDetails(this._UserProfile, dataPointCollectionDefMaint, parameters, request, out result) : this.AddMethod((Method) new DataPointCollectionDefMaintMethod(dataPointCollectionDefMaint, DataPointCollectionDefMaintMethods.LoadESigDetails, (DataPointCollectionDefMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) dataPointCollectionDefMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((DataPointCollectionDefMaint) null, (DataPointCollectionDefMaint_LoadESigDetails_Parameters) null, (DataPointCollectionDefMaint_Request) null, out DataPointCollectionDefMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      DataPointCollectionDefMaint dataPointCollectionDefMaint)
    {
      return this.LoadESigDetails(dataPointCollectionDefMaint, (DataPointCollectionDefMaint_LoadESigDetails_Parameters) null, (DataPointCollectionDefMaint_Request) null, out DataPointCollectionDefMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      DataPointCollectionDefMaint dataPointCollectionDefMaint,
      DataPointCollectionDefMaint_Request request,
      out DataPointCollectionDefMaint_Result result)
    {
      return this.LoadESigDetails(dataPointCollectionDefMaint, (DataPointCollectionDefMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      DataPointCollectionDefMaint dataPointCollectionDefMaint,
      DataPointCollectionDefMaint_Parameters parameters,
      DataPointCollectionDefMaint_Request request,
      out DataPointCollectionDefMaint_Result result)
    {
      result = (DataPointCollectionDefMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) dataPointCollectionDefMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDataPointCollectionDefMaintService) this._Channel).New(this._UserProfile, dataPointCollectionDefMaint, parameters, request, out result) : this.AddMethod((Method) new DataPointCollectionDefMaintMethod(dataPointCollectionDefMaint, DataPointCollectionDefMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) dataPointCollectionDefMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((DataPointCollectionDefMaint) null, (DataPointCollectionDefMaint_Parameters) null, (DataPointCollectionDefMaint_Request) null, out DataPointCollectionDefMaint_Result _);
    }

    public ResultStatus New(
      DataPointCollectionDefMaint dataPointCollectionDefMaint)
    {
      return this.New(dataPointCollectionDefMaint, (DataPointCollectionDefMaint_Parameters) null, (DataPointCollectionDefMaint_Request) null, out DataPointCollectionDefMaint_Result _);
    }

    public ResultStatus New(
      DataPointCollectionDefMaint dataPointCollectionDefMaint,
      DataPointCollectionDefMaint_Request request,
      out DataPointCollectionDefMaint_Result result)
    {
      return this.New(dataPointCollectionDefMaint, (DataPointCollectionDefMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      DataPointCollectionDefMaint dataPointCollectionDefMaint,
      DataPointCollectionDefMaint_Parameters parameters,
      DataPointCollectionDefMaint_Request request,
      out DataPointCollectionDefMaint_Result result)
    {
      result = (DataPointCollectionDefMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) dataPointCollectionDefMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDataPointCollectionDefMaintService) this._Channel).NewCopy(this._UserProfile, dataPointCollectionDefMaint, parameters, request, out result) : this.AddMethod((Method) new DataPointCollectionDefMaintMethod(dataPointCollectionDefMaint, DataPointCollectionDefMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) dataPointCollectionDefMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((DataPointCollectionDefMaint) null, (DataPointCollectionDefMaint_Parameters) null, (DataPointCollectionDefMaint_Request) null, out DataPointCollectionDefMaint_Result _);
    }

    public ResultStatus NewCopy(
      DataPointCollectionDefMaint dataPointCollectionDefMaint)
    {
      return this.NewCopy(dataPointCollectionDefMaint, (DataPointCollectionDefMaint_Parameters) null, (DataPointCollectionDefMaint_Request) null, out DataPointCollectionDefMaint_Result _);
    }

    public ResultStatus NewCopy(
      DataPointCollectionDefMaint dataPointCollectionDefMaint,
      DataPointCollectionDefMaint_Request request,
      out DataPointCollectionDefMaint_Result result)
    {
      return this.NewCopy(dataPointCollectionDefMaint, (DataPointCollectionDefMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRev(
      DataPointCollectionDefMaint dataPointCollectionDefMaint,
      DataPointCollectionDefMaint_Parameters parameters,
      DataPointCollectionDefMaint_Request request,
      out DataPointCollectionDefMaint_Result result)
    {
      result = (DataPointCollectionDefMaint_Result) null;
      this.OnBeforeCall(nameof (NewRev), (DCObject) dataPointCollectionDefMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDataPointCollectionDefMaintService) this._Channel).NewRev(this._UserProfile, dataPointCollectionDefMaint, parameters, request, out result) : this.AddMethod((Method) new DataPointCollectionDefMaintMethod(dataPointCollectionDefMaint, DataPointCollectionDefMaintMethods.NewRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRev), res, (DCObject) dataPointCollectionDefMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRev()
    {
      return this.NewRev((DataPointCollectionDefMaint) null, (DataPointCollectionDefMaint_Parameters) null, (DataPointCollectionDefMaint_Request) null, out DataPointCollectionDefMaint_Result _);
    }

    public ResultStatus NewRev(
      DataPointCollectionDefMaint dataPointCollectionDefMaint)
    {
      return this.NewRev(dataPointCollectionDefMaint, (DataPointCollectionDefMaint_Parameters) null, (DataPointCollectionDefMaint_Request) null, out DataPointCollectionDefMaint_Result _);
    }

    public ResultStatus NewRev(
      DataPointCollectionDefMaint dataPointCollectionDefMaint,
      DataPointCollectionDefMaint_Request request,
      out DataPointCollectionDefMaint_Result result)
    {
      return this.NewRev(dataPointCollectionDefMaint, (DataPointCollectionDefMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRevCopy(
      DataPointCollectionDefMaint dataPointCollectionDefMaint,
      DataPointCollectionDefMaint_Parameters parameters,
      DataPointCollectionDefMaint_Request request,
      out DataPointCollectionDefMaint_Result result)
    {
      result = (DataPointCollectionDefMaint_Result) null;
      this.OnBeforeCall(nameof (NewRevCopy), (DCObject) dataPointCollectionDefMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDataPointCollectionDefMaintService) this._Channel).NewRevCopy(this._UserProfile, dataPointCollectionDefMaint, parameters, request, out result) : this.AddMethod((Method) new DataPointCollectionDefMaintMethod(dataPointCollectionDefMaint, DataPointCollectionDefMaintMethods.NewRevCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRevCopy), res, (DCObject) dataPointCollectionDefMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRevCopy()
    {
      return this.NewRevCopy((DataPointCollectionDefMaint) null, (DataPointCollectionDefMaint_Parameters) null, (DataPointCollectionDefMaint_Request) null, out DataPointCollectionDefMaint_Result _);
    }

    public ResultStatus NewRevCopy(
      DataPointCollectionDefMaint dataPointCollectionDefMaint)
    {
      return this.NewRevCopy(dataPointCollectionDefMaint, (DataPointCollectionDefMaint_Parameters) null, (DataPointCollectionDefMaint_Request) null, out DataPointCollectionDefMaint_Result _);
    }

    public ResultStatus NewRevCopy(
      DataPointCollectionDefMaint dataPointCollectionDefMaint,
      DataPointCollectionDefMaint_Request request,
      out DataPointCollectionDefMaint_Result result)
    {
      return this.NewRevCopy(dataPointCollectionDefMaint, (DataPointCollectionDefMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      DataPointCollectionDefMaint dataPointCollectionDefMaint,
      DataPointCollectionDefMaint_Parameters parameters,
      DataPointCollectionDefMaint_Request request,
      out DataPointCollectionDefMaint_Result result)
    {
      result = (DataPointCollectionDefMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) dataPointCollectionDefMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDataPointCollectionDefMaintService) this._Channel).SaveAs(this._UserProfile, dataPointCollectionDefMaint, parameters, request, out result) : this.AddMethod((Method) new DataPointCollectionDefMaintMethod(dataPointCollectionDefMaint, DataPointCollectionDefMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) dataPointCollectionDefMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((DataPointCollectionDefMaint) null, (DataPointCollectionDefMaint_Parameters) null, (DataPointCollectionDefMaint_Request) null, out DataPointCollectionDefMaint_Result _);
    }

    public ResultStatus SaveAs(
      DataPointCollectionDefMaint dataPointCollectionDefMaint)
    {
      return this.SaveAs(dataPointCollectionDefMaint, (DataPointCollectionDefMaint_Parameters) null, (DataPointCollectionDefMaint_Request) null, out DataPointCollectionDefMaint_Result _);
    }

    public ResultStatus SaveAs(
      DataPointCollectionDefMaint dataPointCollectionDefMaint,
      DataPointCollectionDefMaint_Request request,
      out DataPointCollectionDefMaint_Result result)
    {
      return this.SaveAs(dataPointCollectionDefMaint, (DataPointCollectionDefMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAsRev(
      DataPointCollectionDefMaint dataPointCollectionDefMaint,
      DataPointCollectionDefMaint_Parameters parameters,
      DataPointCollectionDefMaint_Request request,
      out DataPointCollectionDefMaint_Result result)
    {
      result = (DataPointCollectionDefMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAsRev), (DCObject) dataPointCollectionDefMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDataPointCollectionDefMaintService) this._Channel).SaveAsRev(this._UserProfile, dataPointCollectionDefMaint, parameters, request, out result) : this.AddMethod((Method) new DataPointCollectionDefMaintMethod(dataPointCollectionDefMaint, DataPointCollectionDefMaintMethods.SaveAsRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAsRev), res, (DCObject) dataPointCollectionDefMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAsRev()
    {
      return this.SaveAsRev((DataPointCollectionDefMaint) null, (DataPointCollectionDefMaint_Parameters) null, (DataPointCollectionDefMaint_Request) null, out DataPointCollectionDefMaint_Result _);
    }

    public ResultStatus SaveAsRev(
      DataPointCollectionDefMaint dataPointCollectionDefMaint)
    {
      return this.SaveAsRev(dataPointCollectionDefMaint, (DataPointCollectionDefMaint_Parameters) null, (DataPointCollectionDefMaint_Request) null, out DataPointCollectionDefMaint_Result _);
    }

    public ResultStatus SaveAsRev(
      DataPointCollectionDefMaint dataPointCollectionDefMaint,
      DataPointCollectionDefMaint_Request request,
      out DataPointCollectionDefMaint_Result result)
    {
      return this.SaveAsRev(dataPointCollectionDefMaint, (DataPointCollectionDefMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      DataPointCollectionDefMaint dataPointCollectionDefMaint,
      DataPointCollectionDefMaint_Parameters parameters,
      DataPointCollectionDefMaint_Request request,
      out DataPointCollectionDefMaint_Result result)
    {
      result = (DataPointCollectionDefMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) dataPointCollectionDefMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDataPointCollectionDefMaintService) this._Channel).UnFreeze(this._UserProfile, dataPointCollectionDefMaint, parameters, request, out result) : this.AddMethod((Method) new DataPointCollectionDefMaintMethod(dataPointCollectionDefMaint, DataPointCollectionDefMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) dataPointCollectionDefMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((DataPointCollectionDefMaint) null, (DataPointCollectionDefMaint_Parameters) null, (DataPointCollectionDefMaint_Request) null, out DataPointCollectionDefMaint_Result _);
    }

    public ResultStatus UnFreeze(
      DataPointCollectionDefMaint dataPointCollectionDefMaint)
    {
      return this.UnFreeze(dataPointCollectionDefMaint, (DataPointCollectionDefMaint_Parameters) null, (DataPointCollectionDefMaint_Request) null, out DataPointCollectionDefMaint_Result _);
    }

    public ResultStatus UnFreeze(
      DataPointCollectionDefMaint dataPointCollectionDefMaint,
      DataPointCollectionDefMaint_Request request,
      out DataPointCollectionDefMaint_Result result)
    {
      return this.UnFreeze(dataPointCollectionDefMaint, (DataPointCollectionDefMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDeleteAllRevisions(
      DCObject dataPointCollectionDefMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DataPointCollectionDefMaint_Result result1;
        ResultStatus resultStatus = this.DeleteAllRevisions((DataPointCollectionDefMaint) dataPointCollectionDefMaint, (DataPointCollectionDefMaint_Parameters) parameters, (DataPointCollectionDefMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRev(
      DCObject dataPointCollectionDefMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DataPointCollectionDefMaint_Result result1;
        ResultStatus resultStatus = this.NewRev((DataPointCollectionDefMaint) dataPointCollectionDefMaint, (DataPointCollectionDefMaint_Parameters) parameters, (DataPointCollectionDefMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRevCopy(
      DCObject dataPointCollectionDefMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DataPointCollectionDefMaint_Result result1;
        ResultStatus resultStatus = this.NewRevCopy((DataPointCollectionDefMaint) dataPointCollectionDefMaint, (DataPointCollectionDefMaint_Parameters) parameters, (DataPointCollectionDefMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAsRev(
      DCObject dataPointCollectionDefMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DataPointCollectionDefMaint_Result result1;
        ResultStatus resultStatus = this.SaveAsRev((DataPointCollectionDefMaint) dataPointCollectionDefMaint, (DataPointCollectionDefMaint_Parameters) parameters, (DataPointCollectionDefMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnDelete(
      DCObject dataPointCollectionDefMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DataPointCollectionDefMaint_Result result1;
        ResultStatus resultStatus = this.Delete((DataPointCollectionDefMaint) dataPointCollectionDefMaint, (DataPointCollectionDefMaint_Parameters) parameters, (DataPointCollectionDefMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject dataPointCollectionDefMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DataPointCollectionDefMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((DataPointCollectionDefMaint) dataPointCollectionDefMaint, (DataPointCollectionDefMaint_Parameters) parameters, (DataPointCollectionDefMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject dataPointCollectionDefMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DataPointCollectionDefMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((DataPointCollectionDefMaint) dataPointCollectionDefMaint, (DataPointCollectionDefMaint_LoadESigDetails_Parameters) parameters, (DataPointCollectionDefMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject dataPointCollectionDefMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DataPointCollectionDefMaint_Result result1;
        ResultStatus resultStatus = this.New((DataPointCollectionDefMaint) dataPointCollectionDefMaint, (DataPointCollectionDefMaint_Parameters) parameters, (DataPointCollectionDefMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject dataPointCollectionDefMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DataPointCollectionDefMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((DataPointCollectionDefMaint) dataPointCollectionDefMaint, (DataPointCollectionDefMaint_Parameters) parameters, (DataPointCollectionDefMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject dataPointCollectionDefMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DataPointCollectionDefMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((DataPointCollectionDefMaint) dataPointCollectionDefMaint, (DataPointCollectionDefMaint_Parameters) parameters, (DataPointCollectionDefMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject dataPointCollectionDefMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DataPointCollectionDefMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((DataPointCollectionDefMaint) dataPointCollectionDefMaint, (DataPointCollectionDefMaint_Parameters) parameters, (DataPointCollectionDefMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject dataPointCollectionDefMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DataPointCollectionDefMaint_Result result1;
        ResultStatus resultStatus = this.Load((DataPointCollectionDefMaint) dataPointCollectionDefMaint, (DataPointCollectionDefMaint_Parameters) parameters, (DataPointCollectionDefMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject dataPointCollectionDefMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DataPointCollectionDefMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((DataPointCollectionDefMaint) dataPointCollectionDefMaint, (DataPointCollectionDefMaint_Parameters) parameters, (DataPointCollectionDefMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      DataPointCollectionDefMaint_Request request,
      out DataPointCollectionDefMaint_Result result)
    {
      result = (DataPointCollectionDefMaint_Result) null;
      try
      {
        DataPointCollectionDefMaintMethod[] methods = new DataPointCollectionDefMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IDataPointCollectionDefMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        DataPointCollectionDefMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((DataPointCollectionDefMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      DataPointCollectionDefMaint cdo,
      DataPointCollectionDefMaint_Request request,
      out DataPointCollectionDefMaint_Result result)
    {
      result = (DataPointCollectionDefMaint_Result) null;
      try
      {
        return ((IDataPointCollectionDefMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        DataPointCollectionDefMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((DataPointCollectionDefMaint) cdo, (DataPointCollectionDefMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      DataPointCollectionDefMaint_Request request,
      out DataPointCollectionDefMaint_Result result)
    {
      return this.GetEnvironment((DataPointCollectionDefMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      DataPointCollectionDefMaint cdo,
      DataPointCollectionDefMaint_Request request,
      out DataPointCollectionDefMaint_Result result)
    {
      result = (DataPointCollectionDefMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDataPointCollectionDefMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new DataPointCollectionDefMaintMethod(cdo, DataPointCollectionDefMaintMethods.ExecuteTransaction, (DataPointCollectionDefMaint_Parameters) null));
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
        DataPointCollectionDefMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((DataPointCollectionDefMaint) cdo, (DataPointCollectionDefMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(DataPointCollectionDefMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (DataPointCollectionDefMaint_Request) null, out DataPointCollectionDefMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      DataPointCollectionDefMaint_Request request,
      out DataPointCollectionDefMaint_Result result)
    {
      return this.ExecuteTransaction((DataPointCollectionDefMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(DataPointCollectionDefMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new DataPointCollectionDefMaintMethod(cdo, DataPointCollectionDefMaintMethods.AddDataTransaction, (DataPointCollectionDefMaint_Parameters) null));
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
        return this.AddDataTransaction((DataPointCollectionDefMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
