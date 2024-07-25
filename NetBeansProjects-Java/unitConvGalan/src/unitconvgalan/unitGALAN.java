package unitconvgalan;

public class unitGALAN extends javax.swing.JFrame {

    public unitGALAN() {
        initComponents();
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        processGalan = new javax.swing.JButton();
        choicesGalan = new javax.swing.JComboBox<>();
        L2galan = new javax.swing.JLabel();
        inputGalan = new javax.swing.JTextField();
        resultGalan = new javax.swing.JTextField();
        unitGalan = new javax.swing.JLabel();
        L1Galan = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        processGalan.setBackground(new java.awt.Color(153, 255, 153));
        processGalan.setText("PROCESS");
        processGalan.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                processGalanActionPerformed(evt);
            }
        });

        choicesGalan.setBackground(new java.awt.Color(255, 204, 204));
        choicesGalan.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Area-Meters", "Km-Meters", "Miles-Km", "Kg-lbs", "Gallon-Liters", "Liters-ML", " " }));
        choicesGalan.setBorder(new javax.swing.border.MatteBorder(null));
        choicesGalan.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                choicesGalanActionPerformed(evt);
            }
        });

        L2galan.setText("RESULT : ");

        resultGalan.setBackground(new java.awt.Color(204, 204, 204));
        resultGalan.setHorizontalAlignment(javax.swing.JTextField.LEFT);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(39, 39, 39)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(L1Galan, javax.swing.GroupLayout.PREFERRED_SIZE, 90, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(L2galan, javax.swing.GroupLayout.PREFERRED_SIZE, 68, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(choicesGalan, javax.swing.GroupLayout.PREFERRED_SIZE, 128, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(inputGalan, javax.swing.GroupLayout.PREFERRED_SIZE, 100, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(resultGalan, javax.swing.GroupLayout.PREFERRED_SIZE, 100, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addComponent(unitGalan, javax.swing.GroupLayout.PREFERRED_SIZE, 70, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addComponent(processGalan, javax.swing.GroupLayout.PREFERRED_SIZE, 100, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addGap(25, 25, 25)
                .addComponent(choicesGalan, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(inputGalan, javax.swing.GroupLayout.PREFERRED_SIZE, 35, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(L1Galan, javax.swing.GroupLayout.PREFERRED_SIZE, 35, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(18, 18, 18)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                        .addComponent(L2galan, javax.swing.GroupLayout.PREFERRED_SIZE, 35, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addComponent(resultGalan, javax.swing.GroupLayout.PREFERRED_SIZE, 35, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addComponent(unitGalan, javax.swing.GroupLayout.PREFERRED_SIZE, 35, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(18, 18, 18)
                .addComponent(processGalan, javax.swing.GroupLayout.PREFERRED_SIZE, 40, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap(31, Short.MAX_VALUE))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void processGalanActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_processGalanActionPerformed
        double Igalan1, meterGalan;
        Igalan1 = Double.parseDouble(inputGalan.getText());
        switch (choicesGalan.getSelectedItem().toString()) {
            case "Area-Meters":
                meterGalan = Math.sqrt(Igalan1);
                resultGalan.setText(Double.toString(meterGalan));
                break;
            case "Km-Meters":
                Igalan1 *= 1000;
                resultGalan.setText(Double.toString(Igalan1));
                break;
            case "Miles-Km":
                Igalan1 *= 1.609;
                resultGalan.setText(Double.toString(Igalan1));
                break;
            case "Kg-lbs":
                Igalan1 *= 2.205;
                resultGalan.setText(Double.toString(Igalan1));
                break;
            case "Gallon-Liters":
                Igalan1 *= 3.785;
                resultGalan.setText(Double.toString(Igalan1));
                break;
            case "Liters-ML":
                Igalan1 *= 1000;
                resultGalan.setText(Double.toString(Igalan1));
                break;

        }
    }//GEN-LAST:event_processGalanActionPerformed

    private void choicesGalanActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_choicesGalanActionPerformed
        if (choicesGalan.getSelectedItem() == "Area-Meters") {
            L1Galan.setText("Squaremeter : ");
            resultGalan.setText("");
            unitGalan.setText("meter/s");
        } else if (choicesGalan.getSelectedItem() == "Km-Meters") {
            L1Galan.setText("Kilometer/s : ");
            resultGalan.setText("");
            unitGalan.setText("meter/s");
        } else if (choicesGalan.getSelectedItem() == "Miles-Km") {
            L1Galan.setText("Mile/s : ");
            resultGalan.setText("");
            unitGalan.setText("kilometer/s");
        } else if (choicesGalan.getSelectedItem() == "Kg-lbs") {
            L1Galan.setText("Kilogram/s : ");
            resultGalan.setText("");
            unitGalan.setText("pound/s");
        } else if (choicesGalan.getSelectedItem() == "Gallon-Liters") {
            L1Galan.setText("Gallon/s : ");
            resultGalan.setText("");
            unitGalan.setText("Liter/s");
        } else {
            L1Galan.setText("Liter/s : ");
            resultGalan.setText("");
            unitGalan.setText("milliLiter/s");
        }
    }//GEN-LAST:event_choicesGalanActionPerformed

    public static void main(String Galan[]) {
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new unitGALAN().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JLabel L1Galan;
    private javax.swing.JLabel L2galan;
    private javax.swing.JComboBox<String> choicesGalan;
    private javax.swing.JTextField inputGalan;
    private javax.swing.JButton processGalan;
    private javax.swing.JTextField resultGalan;
    private javax.swing.JLabel unitGalan;
    // End of variables declaration//GEN-END:variables
}
