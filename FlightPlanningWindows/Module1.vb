Imports CMT
Module Module1
    Public objMT As IMotionTracker
    Public D_THETA = 3.14159265 / 180
    Public Hscale As Double = 128 / (FlightPlanning.MxHorDis.Text * 2) 'Finding the horizontal scale 1m = how many pixels
    Public VScale As Double = 128 / (FlightPlanning.MxVerDis.Text * 2)


End Module
